using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLVT_DATHANGD17
{
    public partial class VatTuForm : DevExpress.XtraEditors.XtraForm
    {
        public int vitri;
        private bool insertSession = false;
        private CommandManager cmdManager;
        public VatTuForm()
        {
            InitializeComponent();
            vitri = 0;
            cmdManager = new CommandManager();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vatTuBDS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void VatTuForm_Load(object sender, EventArgs e)
        {
            qLVT_DATHANGDataSet.EnforceConstraints = false;
            refreshTable();

            // Sao chép danh sách phân mảnh + server tương ứng lấy khi đăng nhập
            comboBoxBranch.DataSource = Program.bds_dspm;
            comboBoxBranch.DisplayMember = "TENCN";
            comboBoxBranch.ValueMember = "TENSERVER";
            comboBoxBranch.SelectedIndex = Program.mChinhanh;

            // Kiểm tra phân quyền hiện tại, nếu là CONGTY thì mới cho phép thay đổi chi nhánh băng comboBoxBranch, vô hiệu hóa các nút lệnh
            if (Program.userRole == "CongTy")
            {
                comboBoxBranch.Enabled = true;
                groupBox1.Enabled = false;
                addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = saveBtn.Enabled = cancelBtn.Enabled = false;
            }
            else // Các phân quyền khác như CHINHANH, USER thì không thể lựa chọn chi nhánh khác
            {
                comboBoxBranch.Enabled = false;
                groupBox1.Enabled = false;
                saveBtn.Enabled = cancelBtn.Enabled = false;
            }
            // Thiết lập một số thuộc tính mặc đinh cho các widget nhập dữ liệu theo ràng buộc của database
            maVTTE.Properties.MaxLength = 4;
            tenVTTE.Properties.MaxLength = 30;
            tenVTTE.Properties.MaxLength = 15;
            SLTTE.Properties.MinValue = 0;
            SLTTE.Properties.MaxValue = 1000000000;
            DVTTE.Properties.MaxLength = 15;


        }

        private void refreshTable() {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPX);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPN);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTDDH);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet.Vattu);
        }


        public void updateTableAdapter()
        {
            vatTuBDS.EndEdit();
            vatTuBDS.ResetCurrentItem();
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Update(this.qLVT_DATHANGDataSet.Vattu);
        }

        private void comboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshBtn.PerformClick();
            try
            {
                if (comboBoxBranch.SelectedValue.ToString() == "System.Data.DataRowView")
                    return;
                // Gán chi nhánh mới
                Program.servername = comboBoxBranch.SelectedValue.ToString();
                // Dùng SUPPORT_CONNECT để kết nối tới server mới thay cho login cũ nếu như thay đổi chi nhánh mới trên comboBoxBranch
                if (Program.mChinhanh != comboBoxBranch.SelectedIndex)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                // Dung tài khoản khi đăng nhập nếu như chọn lại chi nhánh chọn khi đăng nhập
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == false)
                    MessageBox.Show($"Không thể kết nối đến server {Program.servername}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    //MessageBox.Show(Program.connstr)
                    refreshTable();
                }
            }
            catch (NullReferenceException nullRef)
            {
                return;
            }
        }

        private void addBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
          
            modifyUIButtonState();
            
            // Gọi tập lệnh của Binding Source;
            cmdManager.prepare(new InsertAction(vatTuBDS,"MAVT"));

            // Vô hiệu hóa phần xem grid
            maVTTE.Enabled = true;
            insertSession = true;
            
        }

        private void updateBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            cmdManager.prepare(new UpdateAction(vatTuBDS, "MAVT"));
          
            modifyUIButtonState();
            maVTTE.Enabled = false;
        }

        private void deleteBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (cTDDHBindingSource.Count > 0 || cTPNBindingSource.Count > 0 || cTPXBindingSource.Count > 0)
                MessageBox.Show($"Vật tư {maVTTE.Text} {tenVTTE.Text} đã tạo phiếu nên không thể xóa :3", "Lỗi xóa vật tư", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string delMaNV = "";
                if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    try
                    {
                        delMaNV = ((DataRowView)vatTuBDS[vatTuBDS.Position])["MAVT"].ToString();
                        cmdManager.execute(new DeleteAction(vatTuBDS, "MAVT"));
                        undoBtn.Enabled = true;
                        redoBtn.Enabled = false;
                        this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.vattuTableAdapter.Update(this.qLVT_DATHANGDataSet.Vattu);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"Xóa vật tư không thành công :3 {exception.Message}", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet.Vattu);
                        vatTuBDS.Position = vatTuBDS.Find("MAVT", delMaNV);
                    }
            }
            if (vatTuBDS.Count == 0)
                deleteBtn.Enabled = false;
        }



        private void saveBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (maVTTE.Text.Trim() == "")
            {
                MessageBox.Show("Mã vật tư không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maVTTE.Focus();
                return;
            }
            if (tenVTTE.Text.Trim() == "")
            {
                MessageBox.Show("Tên vật tư không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tenVTTE.Focus();
                return;
            }
            if (DVTTE.Text.Trim() != "Cái") // chua biet
            {
                MessageBox.Show("Đơn vị tính không chính xác (đơn vị mặc định là Cái)", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DVTTE.Focus();
                DVTTE.Text = "Cái";
                return;
            }
            if (SLTTE.Value < 0 || SLTTE.Value.ToString().Trim() == "")
            {
                MessageBox.Show("Số lượng nhập không đúng ", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SLTTE.Focus();
                SLTTE.Value = 0;
                return;
            }
            try
            {
                if (insertSession)
                {
                    string command = $"select TENVT from VATTU where MAVT = '{maVTTE.Text.Trim()}'";
                    Program.myReader = Program.ExecSqlDataReader(command);
                    if (Program.myReader != null)
                    {
                        if (Program.myReader.Read())
                        {
                            MessageBox.Show($"Mã vật tư tồn tại: {maVTTE.Text} {Program.myReader.GetString(0)}");
                     
                            Program.myReader.Close();
                            return;
                        }
                        else
                        {
                            cmdManager.commit(); // lay data cho redo
                            updateTableAdapter();
                            insertSession = false;
                        }
                        Program.myReader.Close();
                    }
                   
                    
                }
                else
                {
                    cmdManager.commit(); // lay data cho redo
                    updateTableAdapter();
                }
                viewUIButtonState();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void cancelBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (insertSession)
            {
                vatTuBDS.CancelEdit();
                insertSession = false;
            }
            cmdManager.clearLastNode();// xoa node khi huy
            viewUIButtonState();
            refreshBtn.PerformClick();
            vatTuBDS.Position = vitri;
           
        }

        private void refreshBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                // Đưa BindingSource của nhân viên về mặc định
                vatTuBDS.RemoveFilter();
                //this.vATTUTableAdapter.Fill(this.DS.VATTU);
                refreshTable();
            }
            catch (Exception exception)
            {
                MessageBox.Show($" <3 {exception.Message}", "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

        private void undoBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            cmdManager.undo();
            updateTableAdapter();
            redoBtn.Enabled = true;
            if (cmdManager.undoStackSize() == 0) {
                undoBtn.Enabled = false;
            }
           
        }

        private void redoBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            cmdManager.redo();
            updateTableAdapter();
            undoBtn.Enabled = true;
            if (cmdManager.redoStackSize() == 0)
            {
                redoBtn.Enabled = false;
            }
            
        }


        private void modifyUIButtonState()
        {
            vitri = vatTuBDS.Position;
            groupBox1.Enabled = true;
            vattuGridControl.Enabled = false;
            saveBtn.Enabled = cancelBtn.Enabled = true;
            addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = refreshBtn.Enabled = undoBtn.Enabled = redoBtn.Enabled = false;
        }

        private void viewUIButtonState()
        {
            vattuGridControl.Enabled = true;
            groupBox1.Enabled = false;
            addBtn.Enabled = updateBtn.Enabled = deleteBtn.Enabled = refreshBtn.Enabled = true;
            saveBtn.Enabled = cancelBtn.Enabled = false;
            if (cmdManager.undoStackSize() == 0)
            {
                undoBtn.Enabled = false;
            }
            else
            {
                undoBtn.Enabled = true;
            }

            if (cmdManager.redoStackSize() == 0)
            {
                redoBtn.Enabled = false;
            }
            else
            {
                redoBtn.Enabled = true;
            }
        }
    }
}