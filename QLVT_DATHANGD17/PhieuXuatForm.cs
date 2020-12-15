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

            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet.Vattu);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);
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

            // Thiết lập một số thuộc tính mặc đinh cho các widget nhập dữ liệu theo ràng buộc của database
            //dONGIASpinEdit.Properties.MinValue = 1;
            //dONGIASpinEdit.Properties.MaxValue = 1000000000;
            //sOLUONGSpinEdit.Properties.MinValue = 1;
            //sOLUONGSpinEdit.Properties.MinValue = 1000000000;
            mAPXTextEdit.Properties.MaxLength = 8;
            mAPXTextEdit1.Properties.MaxLength = 8;
            hOTENKHTextEdit.Properties.MaxLength = 100;
            mAVTTextEdit.Properties.MaxLength = 4;
            mAKHOTextEdit.Properties.MaxLength = 4;
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
            modifyUIState();
            // Gọi tập lệnh của Binding Source;
            cmdManager.prepare(new InsertAction(phieuXuatBDS,"MAPX"));
         
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
                MessageBox.Show("Mã phiếu xuất không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // check khong ton tai o cn hoac check da xoa
            Convert.ToInt32(mANVSpinEdit.Text.Trim());
            int nvpos = 0;
            for (; nvpos < nhanVienBDS.Count; nvpos++) {

                if (((DataRowView)nhanVienBDS[nvpos])["MANV"].ToString().Trim() == mANVSpinEdit.Text.Trim())
                {
                    int ttx = Convert.ToInt32(((DataRowView)nhanVienBDS[nvpos])["TrangThaiXoa"]);
                    string ten = ((DataRowView)nhanVienBDS[nvpos])["TEN"].ToString();
                    break;
                }
            }

            if (nvpos == nhanVienBDS.Count)
            {
                MessageBox.Show("Mã nhân viên không tồn tại", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mAVTTextEdit.Focus();
                return;
            }
            if (Convert.ToInt32(((DataRowView)nhanVienBDS[nvpos])["TrangThaiXoa"]) == 1) {
                MessageBox.Show("Nhân viên này đã chuyển cn", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mAVTTextEdit.Focus();
                return;
            }
            try
            {
                if (insertSession)
                {
                    string command = $"exec SP_TimPX '{mAPXTextEdit.Text.Trim()}'";
                    Program.myReader = Program.ExecSqlDataReader(command);
                    if (Program.myReader != null)
                    {
                      //  MessageBox.Show(command);
                        Program.myReader.Read();
                        MessageBox.Show($"Phiếu xuất đã được lập vào: {Program.myReader.GetDateTime(0)}");
                        Program.myReader.Close();
                        return;
                    }
                    else
                    {
                        cmdManager.commit(); // lay data cho redo
                        insertSession = false;
                        updatePXTableAdapter();

                    }

                }
                else
                {
                    cmdManager.commit(); // lay data cho redo
                    updatePXTableAdapter();
                }

                viewUIState();
                mANVSpinEdit.ReadOnly = true;
                mAKHOTextEdit.ReadOnly = true;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void updateBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri1 = phieuXuatBDS.Position;
            cmdManager.prepare(new UpdateAction(phieuXuatBDS, "MAPX"));
            modifyUIState();
            mAPXTextEdit.ReadOnly = true;
            mANVSpinEdit.ReadOnly = false;
            mAKHOTextEdit.ReadOnly = false;
        }

        private void deleteVTBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                try
                {

                    cmdManager.execute(new DeleteVTAction(cTPXBDS,"MAVT",false));
                    updateCTPXTableAdapter();
                    undoBtn.Enabled = true;
                    redoBtn.Enabled = false;
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
                        cmdManager.execute(new DeleteAction(phieuXuatBDS, "MAPX"));
                        this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phieuXuatTableAdapter.Update(this.qLVT_DATHANGDataSet.PhieuXuat);
                        undoBtn.Enabled = true;
                        redoBtn.Enabled = false;
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
            modifyCTUIState();
            // Gọi tập lệnh của Binding Source;
            cmdManager.prepare(new InsertVTAction(cTPXBDS, "MAVT",false));
            mAPXTextEdit1.ReadOnly = true;
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

                // kiem tra so luong co vuot qua so luong ddh
                int pos = vattuBDS.Find("MAVT", mAVTTextEdit.Text.Trim());
                int soLuonTon = Convert.ToInt32(((DataRowView)vattuBDS[pos])["SOLUONGTON"]);
                int soLuongXuat = Convert.ToInt32(((DataRowView)cTPXBDS.Current)["SOLUONG"].ToString());
                if (soLuongXuat > soLuonTon)
                {
                    MessageBox.Show($"Số lượng vật tư xuất vượt quá số lượng tồn", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // chua kt ma vt ton tai
                cmdManager.commit(); // lay data cho redo
                updateCTPXTableAdapter();

                viewUIState();
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
            cmdManager.clearLastNode();
            viewUIState();

            refreshBtn.PerformClick();
            cTPXBDS.Position = vitri2;
            phieuXuatBDS.Position = vitri1;
            

        }

        private void viewUIState()
        {
            phieuXuatGridControl.Enabled = true;
            cTPXGridControl.Enabled = true;

            addBtn.Enabled = updateBtn.Enabled = deleteBtn.Enabled = refreshBtn.Enabled = true;
            addVTBtn.Enabled = deleteVTBtn.Enabled = true;
            saveVTBtn.Enabled = saveBtn.Enabled = cancelBtn.Enabled = false;

            thongTinGroupBox.Enabled = false;
            chiTietGroupBox.Enabled = false;

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


        private void modifyCTUIState()
        {
            cTPXGridControl.Enabled = false;
            phieuXuatGridControl.Enabled = false;
            saveVTBtn.Enabled = cancelBtn.Enabled = true;
            addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = refreshBtn.Enabled = addVTBtn.Enabled = deleteVTBtn.Enabled = saveBtn.Enabled = undoBtn.Enabled = redoBtn.Enabled = false;
            chiTietGroupBox.Enabled = true;
            thongTinGroupBox.Enabled = false;
        }


        private void modifyUIState()
        {
            cTPXGridControl.Enabled = false;
            phieuXuatGridControl.Enabled = false;
            addBtn.Enabled = updateBtn.Enabled = deleteBtn.Enabled = refreshBtn.Enabled = undoBtn.Enabled = redoBtn.Enabled = false;
            addVTBtn.Enabled = deleteVTBtn.Enabled = saveVTBtn.Enabled = false;
            saveBtn.Enabled = cancelBtn.Enabled = true;
            chiTietGroupBox.Enabled = false;
            thongTinGroupBox.Enabled = true;
        }
    }
}