using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLVT_DATHANGD17
{
    public partial class KhoForm : DevExpress.XtraEditors.XtraForm
    {

        public int vitri;
        public string macn;
        private CommandManager cmdManager;
        private bool insertSession = false;
        public KhoForm()
        {
            InitializeComponent();
            vitri = 0;
            cmdManager = new CommandManager();
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
                    refreshTableAdapter();
                    //MessageBox.Show(macn);
                }
            }
            catch (NullReferenceException nullRef)
            {
                return;
            }
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoBDS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void refreshTableAdapter()
        {
            // TODO: This line of code loads data into the 'dS.KHO' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);

            // TODO: This line of code loads data into the 'DS.PHIEUXUAT' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuXuat);

            // TODO: This line of code loads data into the 'DS.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuNhap);

            // TODO: This line of code loads data into the 'DS.DATHANG' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);
        }

        private void updateTableAdapter()
        {
            khoBDS.EndEdit();
            khoBDS.ResetCurrentItem();
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Update(this.qLVT_DATHANGDataSet.Kho);
        }

        private void KhoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.ChiNhanh' table. You can move, or remove it, as needed.
            this.chiNhanhTableAdapter.Fill(this.qLVT_DATHANGDataSet.ChiNhanh);
            qLVT_DATHANGDataSet.EnforceConstraints = false;
            refreshTableAdapter();
            // Sao chép danh sách phân mảnh + server tương ứng lấy khi đăng nhập
            comboBoxBranch.DataSource = Program.bds_dspm;
            comboBoxBranch.DisplayMember = "TENCN";
            comboBoxBranch.ValueMember = "TENSERVER";
            comboBoxBranch.SelectedIndex = Program.mChinhanh;

            macn = ((DataRowView)chiNhanhBDS[0])["MACN"].ToString();

            // Kiểm tra phân quyền hiện tại, nếu là CONGTY thì mới cho phép thay đổi chi nhánh băng comboBoxBranch, vô hiệu hóa các nút lệnh
            if (Program.userRole == "CongTy")
            {
                comboBoxBranch.Enabled = true;
                groupControl1.Enabled = false;
                addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = saveBtn.Enabled = cancelBtn.Enabled = false;
            }
            else // Các phân quyền khác như CHINHANH, USER thì không thể lựa chọn chi nhánh khác
            {
                comboBoxBranch.Enabled = false;
                groupControl1.Enabled = false;
                saveBtn.Enabled = cancelBtn.Enabled = false;
            }
            // Thiết lập một số thuộc tính mặc đinh cho các widget nhập dữ liệu theo ràng buộc của database
            maKhoTE.Properties.MaxLength = 6;
            tenKhoTE.Properties.MaxLength = 30;
            diaChiTE.Properties.MaxLength = 100;
 

        }

        private void addBtn_ItemClick(object sender, ItemClickEventArgs e)
        {          
            cmdManager.prepare(new InsertAction(khoBDS,"MAKHO"));
            // Vô hiệu hóa phần xem grid
            modifyUIButtonState();
            maKhoTE.ReadOnly = false;
            insertSession = true;
        }

        private void updateBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            cmdManager.prepare(new UpdateAction(khoBDS, "MAKHO"));
            modifyUIButtonState();
            maKhoTE.ReadOnly = true;
        }


        private void modifyUIButtonState()
        {
            vitri = khoBDS.Position;
            groupControl1.Enabled = true;
            addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = refreshBtn.Enabled = redoBtn.Enabled = undoBtn.Enabled = false;
            saveBtn.Enabled = cancelBtn.Enabled = true;
            khoGridControl.Enabled = false;
        }

      

        private void deleteBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            //MessageBox.Show($"Số phiếu xuất: {BDSPhieuXuat.Count} \nSố phiếu nhập: {BDSPhieuNhap.Count} \nSố đơn đặt hàng: {BDSDatHang.Count}");
            // Nếu nhân viên đã lập bất kì một phiếu nào thì không đươc phép xóa
            if (datHangBDS.Count > 0 || phieuXuatBDS.Count > 0 || phieuNhapBDS.Count > 0)
                MessageBox.Show($"{maKhoTE.Text} {tenKhoTE.Text} đã có thông tin phiếu nên không thể xóa :3", "Lỗi xóa kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string delMaKho = "";
                if (MessageBox.Show("Bạn có thật sự muốn xóa kho này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    try
                    {
                        delMaKho = ((DataRowView)khoBDS[khoBDS.Position])["MAKHO"].ToString();
                        cmdManager.execute(new DeleteAction(khoBDS, "MAKHO"));
                        this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.khoTableAdapter.Update(this.qLVT_DATHANGDataSet.Kho);
                        undoBtn.Enabled = true;
                        redoBtn.Enabled = false;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"Xóa vật tư không thành công :3 {exception.Message}", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshTableAdapter();
                        khoBDS.Position = khoBDS.Find("MAKHO", delMaKho);
                    }
            }
            if (khoBDS.Count == 0)
                deleteBtn.Enabled = false;
        }

        private void saveBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            groupControl1.Focus();
            if (maKhoTE.Text.Trim() == "")
            {
                MessageBox.Show("Mã kho không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maKhoTE.Focus();
                return;
            }
            if (tenKhoTE.Text.Trim() == "")
            {
                MessageBox.Show("Tên kho không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tenKhoTE.Focus();
                return;
            }
            if (diaChiTE.Text.Trim() == "")
            {
                MessageBox.Show("Đia chỉ kho không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                diaChiTE.Focus();
                return;
            }

            string command1 = $"exec SP_TimTenKho '{tenKhoTE.Text.Trim()}'";
            Program.myReader = Program.ExecSqlDataReader(command1);
            if (Program.myReader != null)
            {
                if (Program.myReader.Read())
                {
                    MessageBox.Show($"Tên kho đã tồn tại");

                    Program.myReader.Close();
                    return;
                }
               
                Program.myReader.Close();
            }

            try
            {
                if (insertSession)
                {
                    string command = $"select TENKHO from KHO where MAKHO = '{maKhoTE.Text.Trim()}'";
                    Program.myReader = Program.ExecSqlDataReader(command);
                    if (Program.myReader != null)
                    {
                        if (Program.myReader.Read())
                        {
                            MessageBox.Show($"Mã kho tồn tại: {maKhoTE.Text} {Program.myReader.GetString(0)}");
                            
                            Program.myReader.Close();
                            return;
                        }
                        else
                        {

                            ((DataRowView)khoBDS.Current)["MACN"] = macn;
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

        private void viewUIButtonState()
        {
            khoGridControl.Enabled = true;
            addBtn.Enabled = updateBtn.Enabled = deleteBtn.Enabled = refreshBtn.Enabled = true;
            saveBtn.Enabled = cancelBtn.Enabled = false;
            groupControl1.Enabled = false;
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

        private void cancelBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (insertSession)
            {
                khoBDS.CancelEdit();
                insertSession = false;
            }
            cmdManager.clearLastNode();
            viewUIButtonState();
            refreshBtn.PerformClick();
            khoBDS.Position = vitri;
            

        }

        private void refreshBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                // Đưa BindingSource của nhân viên về mặc định
                khoBDS.RemoveFilter();
                //this.vATTUTableAdapter.Fill(this.DS.VATTU);
                refreshTableAdapter();
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
            if (cmdManager.undoStackSize() == 0)
            {
                undoBtn.Enabled = false;
            }

        }

        private void redoBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            cmdManager.redo();
            updateTableAdapter();
            if (cmdManager.redoStackSize() == 0)
            {
                redoBtn.Enabled = false;
            }
            undoBtn.Enabled = true;
        }
    }
}