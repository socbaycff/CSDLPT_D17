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
    public partial class PhieuNhapForm : DevExpress.XtraEditors.XtraForm
    {
        public int vitri1;
        public int vitri2;
        public string macn;
        private CommandManager cmdManager;
        private bool insertSession = false;
        public PhieuNhapForm()
        {
            InitializeComponent();
            cmdManager = new CommandManager();
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phieuNhapBDS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void refreshTableAdapter()
        {
            // TODO: This line of code loads data into the 'dS.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuNhap);
            // TODO: This line of code loads data into the 'DS.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPN);

            // TODO: This line of code loads data into the 'DS.KHO' table. You can move, or remove it, as needed.
            //this.kHOTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.kHOTableAdapter.Fill(this.DS.KHO);
            //TODO: This line of code loads data into the 'DS.NHANVIEN' table.You can move, or remove it, as needed.
            //this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
            //TODO: This line of code loads data into the 'DS.SP_InDanhSachNhanVien' table.You can move, or remove it, as needed.
            //this.sP_InDanhSachNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.sP_InDanhSachNhanVienTableAdapter.Fill(this.DS.SP_InDanhSachNhanVien);
            //TODO: This line of code loads data into the 'DS.DATHANG' table.You can move, or remove it, as needed.
            //this.dATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.dATHANGTableAdapter.Fill(this.DS.DATHANG);

            //TODO: This line of code loads data into the 'DS.CTDDH' table.You can move, or remove it, as needed.
            //this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
        }
        private void updatePNTableAdapter()
        {
            phieuNhapBDS.EndEdit();
            phieuNhapBDS.ResetCurrentItem();
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Update(this.qLVT_DATHANGDataSet.PhieuNhap);
        }
        private void updateCTPNTableAdapter()
        {
            cTPNBDS.EndEdit();
            cTPNBDS.ResetCurrentItem();
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Update(this.qLVT_DATHANGDataSet.CTPN);
        }
        // Bật-Tắt các widget nhập liệu trên groupControl1 - Phiếu nhập
        private void enableGroupControl1Input(bool enableState)
        {
            mAPNTextEdit1.Enabled = nGAYDateEdit.Enabled = enableState;
            mANVSpinEdit.Enabled = mAKHOTextEdit.Enabled = masoDDHTextEdit.Enabled = !enableState;
        }
        // Bật tắt các widget nhập liệu chỉ định sẵn trên groupControl1 - Phiếu nhập
        //private void enableGroupControl1FInput(bool enableState)
        //{
        //    comboBoxFMaNV.Enabled = comboBoxFMaKho.Enabled = comboBoxFMaDonDH.Enabled = enableState;
        //}
        // Bật-Tắt các widget nhập liệu trên groupControl2 - Chi tiết Phiếu nhập
        private void enableGroupControl2Input(bool enableState)
        {
            sOLUONGSpinEdit.Enabled = dONGIASpinEdit.Enabled = enableState;
            mAVTTextEdit.Enabled = mAPNTextEdit1.Enabled = false;
        }
        // Bật-Tắt các widget nhập liệu chỉ định trên groupControl2 - Chi tiết Phiếu nhập
        //private void enableGroupControl2FInput(bool enableState)
        //{
        //    comboBoxFMaVT.Enabled = comboBoxFSoLuong.Enabled = enableState;
        //}

        private void PhieuNhapForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
            //// TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.CTPN' table. You can move, or remove it, as needed.
            //this.cTPNTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPN);
            //// TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.PhieuNhap' table. You can move, or remove it, as needed.
            //this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuNhap);
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
                addVTBtn.Enabled  = saveVTBtn.Enabled = false;
            }
            else // Các phân quyền khác như CHINHANH, USER thì không thể lựa chọn chi nhánh khác
            {
                comboBoxBranch.Enabled = false;
                saveBtn.Enabled = cancelBtn.Enabled = saveVTBtn.Enabled  = false;
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

        private void addBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri1 = phieuNhapBDS.Position;
            // Vô hiẹu hóa phần /Grid Control của đơn đặt hàng
            phieuNhapDataGridView.Enabled = false;
            thongTinGroupBox.Enabled = true;
            // Gọi tập lệnh của Binding Source;
            cmdManager.execute(new InsertAction(phieuNhapBDS));
            saveBtn.Enabled = cancelBtn.Enabled = true;
            addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = refreshBtn.Enabled = false; //buttonAddDetails.Enabled = buttonDeleteDetails.Enabled = buttonSaveDetails.Enabled = buttonUndoDetails.Enabled = false;
            // Mở phần chỉnh sửa
            enableGroupControl1Input(true);

            //groupControl2.Enabled = false;
            mAPNTextEdit.ReadOnly = false;
            //spinEditMaNV.Value = int.Parse(comboBoxFMaNV.SelectedValue.ToString().Trim());
            mANVSpinEdit.Enabled = true;
            masoDDHTextEdit.Enabled = true;
            mAKHOTextEdit.Enabled = true;
            insertSession = true;
        }

        private void saveBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (mAPNTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu nhập không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mAPNTextEdit.Focus();
                return;
            }
            if (nGAYDateEdit.Text.Trim() == "")
            {
                MessageBox.Show("Ngày lập đơn không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nGAYDateEdit.Focus();
                return;
            }
            if ((int)mANVSpinEdit.Value < 0 )
            {
                MessageBox.Show("Mã không đúng", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nhanVienBDS.Find("MANV", int.Parse(mANVSpinEdit.Text.Trim())) == -1)
            {
                MessageBox.Show("Mã nhân viên không tồn tại", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mAVTTextEdit.Focus();
                return;
            }

            if (khoBDS.Find("MAKHO", mAKHOTextEdit.Text.Trim()) == -1)
            {
                MessageBox.Show("Mã kho không tồn tại", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mAVTTextEdit.Focus();
                return;
            }

            if (datHangBDS.Find("MasoDDH", masoDDHTextEdit.Text.Trim()) == -1)
            {
                MessageBox.Show("Mã DDH không tồn tại", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mAVTTextEdit.Focus();
                return;
            }

            try
            {
                if (insertSession)
                {
                    // Kiểm tra tính unique của MasoDDH
                    int checkIndex = phieuNhapBDS.Find("MasoDDH", masoDDHTextEdit.Text.Trim());

                    //MessageBox.Show($"{checkIndex}  {BDSPhieuNhap.Position}");
                    if (checkIndex >= 0 && checkIndex != phieuNhapBDS.Position)
                    {
                        MessageBox.Show($"Đơn đặt hàng {masoDDHTextEdit.Text} đã được lập phiếu nhập, không thể tạo thêm phiếu nhập cho đơn hàng này", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Kiểm tra tính hợp lệ của MAPN
                    string command = $"exec SP_KiemTraPhieuNhap '{mAPNTextEdit.Text.Trim()}'";
                    Program.myReader = Program.ExecSqlDataReader(command);
                    if (Program.myReader != null)
                    {
                        MessageBox.Show(command);
                        Program.myReader.Read();
                        MessageBox.Show($"Phiếu nhập đã được lập vào: {Program.myReader.GetDateTime(0)} - Thêm thất bại");
                        Program.myReader.Close();
                        return;
                    }
                    else {
                        ((InsertAction)cmdManager.getLastUndoNode()).getData(); // lay data cho redo
                        insertSession = false;
                        updatePNTableAdapter();
                    }
                
                }
                else {
                    ((UpdateAction)cmdManager.getLastUndoNode()).getData(); // lay data cho redo
                    updatePNTableAdapter();
                }
  
                // Tùy chỉnh lại trạng thái các button sau khi hoàn tất
                phieuNhapDataGridView.Enabled = true;
                //PurchaseDetailsGridControl.Enabled = true;

                addBtn.Enabled = updateBtn.Enabled = deleteBtn.Enabled = refreshBtn.Enabled = true;
                //buttonAddDetails.Enabled = buttonDeleteDetails.Enabled = buttonSaveDetails.Enabled = true;
                saveBtn.Enabled = cancelBtn.Enabled = false;
                thongTinGroupBox.Enabled = false;
                undoBtn.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void undoBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            cmdManager.undo();
            updatePNTableAdapter();
            updateCTPNTableAdapter();
            redoBtn.Enabled = true;
            if (cmdManager.undoStackSize() == 0)
            {
                undoBtn.Enabled = false;
            }
        }

        private void redoBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            cmdManager.redo();
            updatePNTableAdapter();
            updateCTPNTableAdapter();
            if (cmdManager.redoStackSize() == 0)
            {
                redoBtn.Enabled = false;
            }
            undoBtn.Enabled = true;
        }

        private void deleteBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (cTPNBDS.Count > 0)
                MessageBox.Show($" Phiếu nhập {mAPNTextEdit.Text} không thể xóa :3", "Lỗi xóa phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string delMaPN = "";
                if (MessageBox.Show("Bạn có thật sự muốn xóa đơn đặt hàng này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    try
                    {
                        delMaPN = ((DataRowView)phieuNhapBDS[phieuNhapBDS.Position])["MAPN"].ToString();
                        cmdManager.execute(new DeleteAction(phieuNhapBDS));
                        this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phieuNhapTableAdapter.Update(this.qLVT_DATHANGDataSet.PhieuNhap);
                        undoBtn.Enabled = true;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Xóa phiếu nhập không thành công :3", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      //  this.dATHANGTableAdapter.Fill(this.qLVT_DATHANGDataSet.DATHANG);
                        phieuNhapBDS.Position = phieuNhapBDS.Find("MAPN", delMaPN);
                    }
            }
            if (phieuNhapBDS.Count == 0)
                deleteBtn.Enabled = false;
        }
    }
}