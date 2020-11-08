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
    public partial class PhieuXuatForm : DevExpress.XtraEditors.XtraForm
    {
        public int vitri1;
        public int vitri2;
        public string macn;
        private CommandManager cmdManager;
        private bool insertSession = false;
        public PhieuXuatForm()
        {
            InitializeComponent();
            vitri1 = 0;
            vitri2 = 0;
            macn = "";
            cmdManager = new CommandManager();
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phieuXuatBDS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void refreshTableAdapter()
        {

            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPX);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuXuat);

        }

        private void updatePXTableAdapter()
        {
            phieuXuatBDS.EndEdit();
            phieuXuatBDS.ResetCurrentItem();
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Update(this.qLVT_DATHANGDataSet.PhieuXuat);
        }
        private void updateCTPXTableAdapter()
        {
            cTPXBDS.EndEdit();
            cTPXBDS.ResetCurrentItem();
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Update(this.qLVT_DATHANGDataSet.CTPX);
        }

        private void enableGroupControl1Input(bool enableState)
        {
            mAPXTextEdit1.Enabled = nGAYDateEdit.Enabled = enableState;
            mANVSpinEdit.Enabled = mAKHOTextEdit.Enabled = !enableState;
        }

        private void enableGroupControl2Input(bool enableState)
        {
            sOLUONGSpinEdit.Enabled = dONGIASpinEdit.Enabled = enableState;
            mAVTTextEdit.Enabled = mAPXTextEdit1.Enabled = false;
        }

        private void PhieuXuatForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet.Vattu);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);
            // Thiết lập một số thuộc tính mặc đinh cho các widget nhập dữ liệu theo ràng buộc của database
            dONGIASpinEdit.Properties.MinValue = 1;
            dONGIASpinEdit.Properties.MaxValue = 1000000000;
            dONGIASpinEdit.ReadOnly = true;
            qLVT_DATHANGDataSet.EnforceConstraints = false;

            refreshTableAdapter();
            // Sao chép danh sách phân mảnh + server tương ứng lấy khi đăng nhập
            comboBoxBranch.DataSource = Program.bds_dspm;
            comboBoxBranch.DisplayMember = "TENCN";
            comboBoxBranch.ValueMember = "TENSERVER";
            comboBoxBranch.SelectedIndex = Program.mChinhanh;

            // Kiểm tra phân quyền hiện tại, nếu là CONGTY thì mới cho phép thay đổi chi nhánh băng comboBoxBranch, vô hiệu hóa các nút lệnh
            if (Program.userRole == "CongTy")
            {
                comboBoxBranch.Enabled = true;
                addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = saveBtn.Enabled = cancelBtn.Enabled = false;
                addVTBtn.Enabled = saveVTBtn.Enabled = false;
            }
            else // Các phân quyền khác như CHINHANH, USER thì không thể lựa chọn chi nhánh khác
            {
                comboBoxBranch.Enabled = false;
                saveBtn.Enabled = cancelBtn.Enabled = saveVTBtn.Enabled = false;
            }
            // Ban đầu ta chỉ cho phép xem trên gridView - không cho chỉnh sửa nên như chưa nhấn các nút lệnh
            thongTinGroupBox.Enabled = chiTietGroupBox.Enabled = false;
            enableGroupControl1Input(true);
            sOLUONGSpinEdit.ReadOnly = true;

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
                }
            }
            catch (NullReferenceException nullRef)
            {
                return;
            }
        }

        private void refreshBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                // Đưa BindingSource của nhân viên về mặc định
                phieuXuatBDS.RemoveFilter();
                cTPXBDS.RemoveFilter();
                //this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
                refreshTableAdapter();
            }
            catch (Exception exception)
            {
                MessageBox.Show($" <3 {exception.Message}", "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri1 = phieuXuatBDS.Position;
            // Vô hiẹu hóa phần /Grid Control của đơn đặt hàng
            phieuXuatDataGridView.Enabled = false;
            // Gọi tập lệnh của Binding Source;
            cmdManager.execute(new InsertAction(phieuXuatBDS));
            saveBtn.Enabled = cancelBtn.Enabled = true;
            addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = refreshBtn.Enabled = addVTBtn.Enabled = deleteVTBtn.Enabled = saveVTBtn.Enabled = false;
            // Mở phần chỉnh sửa
            thongTinGroupBox.Enabled = true;
            chiTietGroupBox.Enabled = false;
            mAPXTextEdit.ReadOnly = false;
            mANVSpinEdit.Enabled = true;
            mAKHOTextEdit.Enabled = true;
            insertSession = true;
        }

        private void saveBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            thongTinGroupBox.Focus(); //  focus de lay
            if (mAPXTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Mã đơn đặt hàng không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mAPXTextEdit.Focus();
                return;
            }
            //-----------------------------------------------------------
            if (nGAYDateEdit.Text.Trim() == "")
            {
                MessageBox.Show("Ngày lập đơn không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nGAYDateEdit.Focus();
                return;
            }
            if (hOTENKHTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Họ tên khách không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hOTENKHTextEdit.Focus();
                return;
            }
            if (mANVSpinEdit.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên lập không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mANVSpinEdit.Focus();
                return;
            }
            if (mAKHOTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Mã kho không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mAKHOTextEdit.Focus();
                return;
            }
            if (khoBDS.Find("MAKHO", mAKHOTextEdit.Text.Trim()) == -1)
            {
                MessageBox.Show("Mã kho không tồn tại", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mAVTTextEdit.Focus();
                return;
            }

            if (nhanVienBDS.Find("MANV", int.Parse(mANVSpinEdit.Text.Trim())) == -1)
            {
                MessageBox.Show("Mã nhân viên không tồn tại", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mAVTTextEdit.Focus();
                return;
            }
            try
            {
                if (insertSession)
                {
                    string command = $"exec SP_TimDDH '{mAPXTextEdit.Text.Trim()}'";
                    Program.myReader = Program.ExecSqlDataReader(command);
                    if (Program.myReader != null)
                    {
                        MessageBox.Show(command);
                        Program.myReader.Read();
                        MessageBox.Show($"Đơn đặt hàng đã được lập vào: {Program.myReader.GetDateTime(0)}");
                        Program.myReader.Close();
                        return;
                    }
                    else
                    {
                        ((InsertAction)cmdManager.getLastUndoNode()).getData(); // lay data cho redo
                        insertSession = false;
                        updatePXTableAdapter();

                    }

                }
                else
                {
                    ((UpdateAction)cmdManager.getLastUndoNode()).getData(); // lay data cho redo
                    updatePXTableAdapter();
                }

                // Tùy chỉnh lại trạng thái các button sau khi hoàn tất
                phieuXuatDataGridView.Enabled = true;
                cTPXDataGridView.Enabled = true;

                addBtn.Enabled = updateBtn.Enabled = deleteBtn.Enabled = refreshBtn.Enabled = true;
                addVTBtn.Enabled = deleteVTBtn.Enabled = true;
                saveBtn.Enabled = cancelBtn.Enabled = false;
                saveBtn.Enabled = false;
                thongTinGroupBox.Enabled = false;
                mANVSpinEdit.ReadOnly = true;
                mAKHOTextEdit.ReadOnly = true;
                undoBtn.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void updateBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri1 = phieuXuatBDS.Position;
            cmdManager.execute(new UpdateAction(phieuXuatBDS));
            thongTinGroupBox.Enabled = true;
            addBtn.Enabled = updateBtn.Enabled = deleteBtn.Enabled = refreshBtn.Enabled = false;
            addVTBtn.Enabled = deleteVTBtn.Enabled = cancelBtn.Enabled = saveVTBtn.Enabled = false;
            saveBtn.Enabled = cancelBtn.Enabled = true;
            phieuXuatDataGridView.Enabled = false;
            mAPXTextEdit.ReadOnly = true;
            mANVSpinEdit.ReadOnly = false;
            mAKHOTextEdit.ReadOnly = false;
        }

        private void deleteVTBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                try
                {

                    cmdManager.execute(new DeleteAction(cTPXBDS));
                    updateCTPXTableAdapter();
                    undoBtn.Enabled = true;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Xóa chi tiết đơn hàng không thành công :3", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cTPXTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPX);

                }

            if (cTPXBDS.Count == 0)
                deleteVTBtn.Enabled = false;
        }

        private void deleteBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (cTPXBDS.Count > 0 )
                MessageBox.Show($" Đơn hàng {mAPXTextEdit.Text} không thể xóa :3", "Lỗi xóa đơn đặt hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string delMaPX = "";
                if (MessageBox.Show("Bạn có thật sự muốn xóa đơn đặt hàng này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    try
                    {
                        delMaPX = ((DataRowView)phieuXuatBDS[phieuXuatBDS.Position])["MAPX"].ToString();
                        cmdManager.execute(new DeleteAction(phieuXuatBDS));
                        this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phieuXuatTableAdapter.Update(this.qLVT_DATHANGDataSet.PhieuXuat);
                        undoBtn.Enabled = true;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Xóa nhân viên không thành công :3", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.phieuXuatTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuXuat);
                        phieuXuatBDS.Position = phieuXuatBDS.Find("MAPX", delMaPX);
                    }
            }
            if (phieuXuatBDS.Count == 0)
                deleteBtn.Enabled = false;
        }

        private void undoBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            cmdManager.undo();
            updatePXTableAdapter();
            updateCTPXTableAdapter();
            redoBtn.Enabled = true;
            if (cmdManager.undoStackSize() == 0)
            {
                undoBtn.Enabled = false;
            }
        }

        private void redoBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            cmdManager.redo();
            updatePXTableAdapter();
            updateCTPXTableAdapter();
            if (cmdManager.redoStackSize() == 0)
            {
                redoBtn.Enabled = false;
            }
            undoBtn.Enabled = true;
        }

        private void addVTBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri2 = cTPXBDS.Position;

            // Vô hiẹu hóa phần /Grid Control của đơn đặt hàng
            cTPXDataGridView.Enabled = false;
            phieuXuatDataGridView.Enabled = false;
            // Gọi tập lệnh của Binding Source;
            cmdManager.execute(new InsertAction(cTPXBDS));
            saveVTBtn.Enabled = cancelBtn.Enabled = true;
            addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = refreshBtn.Enabled = addVTBtn.Enabled = deleteVTBtn.Enabled = saveBtn.Enabled = undoBtn.Enabled = false;
            // Mở phần chỉnh sửa
            chiTietGroupBox.Enabled = true;
            thongTinGroupBox.Enabled = false;
            mAVTTextEdit.ReadOnly = false;
            // Tự động điền các mã đơn đặt hàng hiện tại và mã vật tư
            mAPXTextEdit1.Text = mAPXTextEdit.Text;
            sOLUONGSpinEdit.ReadOnly = false;
            dONGIASpinEdit.ReadOnly = false;
            //   textEditMaVT.Text = comboBoxPackageName.SelectedValue.ToString().Trim(); dong nay xu ly sau
        }

        private void saveVTBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            chiTietGroupBox.Focus();

            if (sOLUONGSpinEdit.Text.Trim() == "" || sOLUONGSpinEdit.Value < 0)
            {
                MessageBox.Show("Số lượng đặt không được để trống và phải có giá trị dương", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sOLUONGSpinEdit.Focus();
                return;
            }
            if (dONGIASpinEdit.Text.Trim() == "" || dONGIASpinEdit.Value < 0)
            {
                MessageBox.Show("Đơn giá của vật tư không được để trống và phải có giá trị dương", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dONGIASpinEdit.Focus();
                return;
            }
            // check mavt 
            if (vattuBDS.Find("MAVT", mAVTTextEdit.Text.Trim()) == -1)
            {
                MessageBox.Show("Mã vật tư không tồn tại", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mAVTTextEdit.Focus();
                return;
            }
            try
            {
                // check mavt co da co chua
                int checkIndex = -1;
                for (int i = 0; i < cTPXBDS.Count; i++)
                {
                    if (mAVTTextEdit.Text.Trim() == ((DataRowView)cTPXBDS[i])["MAPX"].ToString())
                    {
                        checkIndex = i;
                        break;
                    }
                }

                if (checkIndex >= 0 && checkIndex != cTPXBDS.Position)
                {
                    MessageBox.Show($"Chi tiết cho vật tư này đã được lập vui lòng chọn lại vât tư khác", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // chua kt ma vt ton tai
                ((InsertAction)cmdManager.getLastUndoNode()).getData(); // lay data cho redo
                updateCTPXTableAdapter();
                undoBtn.Enabled = true;
                // Tùy chỉnh lại trạng thái các button sau khi hoàn tất
                phieuXuatDataGridView.Enabled = true;
                cTPXDataGridView.Enabled = true;

                addBtn.Enabled = updateBtn.Enabled = deleteBtn.Enabled = refreshBtn.Enabled = true;
                addVTBtn.Enabled = deleteVTBtn.Enabled = true;
                saveBtn.Enabled = cancelBtn.Enabled = false;
                saveVTBtn.Enabled = false;
                thongTinGroupBox.Enabled = false;
                chiTietGroupBox.Enabled = false;
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

                phieuXuatBDS.CancelEdit();
                cTPXBDS.CancelEdit();
                insertSession = false;
            }

            phieuXuatDataGridView.Enabled = true;
            cTPXDataGridView.Enabled = true;
            thongTinGroupBox.Enabled = false;
            chiTietGroupBox.Enabled = false;

            addBtn.Enabled = updateBtn.Enabled = deleteBtn.Enabled = refreshBtn.Enabled = true;
            addVTBtn.Enabled = deleteVTBtn.Enabled = true;
            saveBtn.Enabled = false;
            saveVTBtn.Enabled = cancelBtn.Enabled = false;

            refreshBtn.PerformClick();
            cTPXBDS.Position = vitri2;
            phieuXuatBDS.Position = vitri1;
            cmdManager.clearLastNode();
            if (cmdManager.undoStackSize() == 0)
            {
                undoBtn.Enabled = false;
            }
        }
    }
}