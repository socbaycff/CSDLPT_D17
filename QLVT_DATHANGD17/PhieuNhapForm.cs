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
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTDDH);

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
  

            // Thiết lập một số thuộc tính mặc đinh cho các widget nhập dữ liệu theo ràng buộc của database
            dONGIASpinEdit.Properties.MinValue = 1;
            dONGIASpinEdit.Properties.MaxValue = 1000000000;
            dONGIASpinEdit.ReadOnly = true;
            mAPNTextEdit.Properties.MaxLength = 8;
            mAPNTextEdit1.Properties.MaxLength = 8;
            masoDDHTextEdit.Properties.MaxLength = 8;
            mAKHOTextEdit.Properties.MaxLength = 4;
            mAVTTextEdit.Properties.MaxLength = 4;
            sOLUONGSpinEdit.Properties.MinValue = 1;
            sOLUONGSpinEdit.Properties.MaxValue = 1000000000;
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
            modifyUIState();
            // Gọi tập lệnh của Binding Source;
            cmdManager.prepare(new InsertAction(phieuNhapBDS,"MAPN"));
        
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
            thongTinGroupBox.Focus();
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
            if ((int)mANVSpinEdit.Value < 0)
            {
                MessageBox.Show("Mã không đúng", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

         
            // check khong ton tai o cn hoac check da xoa
            Convert.ToInt32(mANVSpinEdit.Text.Trim());
            int nvpos = 0;
            for (; nvpos < nhanVienBDS.Count; nvpos++)
            {

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
            if (Convert.ToInt32(((DataRowView)nhanVienBDS[nvpos])["TrangThaiXoa"]) == 1)
            {
                MessageBox.Show("Nhân viên này đã chuyển cn", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mAVTTextEdit.Focus();
                return;
            }

            try
            {
                // Kiểm tra tính unique của MasoDDH
                int checkIndex = phieuNhapBDS.Find("MasoDDH", masoDDHTextEdit.Text.Trim());

                //MessageBox.Show($"{checkIndex}  {BDSPhieuNhap.Position}");
                if (checkIndex >= 0 && checkIndex != phieuNhapBDS.Position)
                {
                    MessageBox.Show($"Đơn đặt hàng {masoDDHTextEdit.Text} đã được lập phiếu nhập, không thể tạo thêm phiếu nhập cho đơn hàng này", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (insertSession)
                {
                   
                    // Kiểm tra tính hợp lệ của MAPN
                    string command = $"exec SP_TimPN '{mAPNTextEdit.Text.Trim()}'";
                    Program.myReader = Program.ExecSqlDataReader(command);
                    if (Program.myReader != null)
                    {
                     //   MessageBox.Show(command);
                        Program.myReader.Read();
                        MessageBox.Show($"Phiếu nhập đã được lập vào: {Program.myReader.GetDateTime(0)} - Thêm thất bại");
                        Program.myReader.Close();
                        return;
                    }
                    else {
                        cmdManager.commit(); // lay data cho redo
                        insertSession = false;
                        updatePNTableAdapter();
                    }
                
                }
                else {
                    cmdManager.commit(); // lay data cho redo
                    updatePNTableAdapter();
                }

                viewUIState();
                datHangComboBox.Enabled = true;
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
                        cmdManager.execute(new DeleteAction(phieuNhapBDS, "MAPN"));
                        this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phieuNhapTableAdapter.Update(this.qLVT_DATHANGDataSet.PhieuNhap);
                        undoBtn.Enabled = true;
                        redoBtn.Enabled = false;
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

        private void updateBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri1 = phieuNhapBDS.Position;
            cmdManager.prepare(new UpdateAction(phieuNhapBDS, "MAPN"));
            modifyUIState();
            mAPNTextEdit.ReadOnly = true;
            masoDDHTextEdit.Enabled = true;
            mANVSpinEdit.Enabled = true;
            mAKHOTextEdit.Enabled = true;
            datHangComboBox.Enabled = false;
        }

        private void cancelBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (insertSession)
            {
                phieuNhapBDS.CancelEdit();
                cTPNBDS.CancelEdit();
                insertSession = false;
            }

            cmdManager.clearLastNode();
            viewUIState();
            datHangComboBox.Enabled = true;

            refreshBtn.PerformClick();
            cTPNBDS.Position = vitri2;
            phieuNhapBDS.Position = vitri1;
            

        }

        private void refreshBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                // Đưa BindingSource của nhân viên về mặc định
                phieuNhapBDS.RemoveFilter();
                cTPNBDS.RemoveFilter();
                //this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
                refreshTableAdapter();
            }
            catch (Exception exception)
            {
                MessageBox.Show($" <3 {exception.Message}", "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addVTBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Nạp mã đơn đặt hàng vào để lấy thông tin chi tiết của đơn đặt hàng - vặt tư đặt - số lượng đặt
          //  comboBoxFMaDonDH.SelectedValue = textEditMaDDH.Text;
        //    Kiểm tra xem thử đơn đặt hàng đã có chi tiết đơn hàng chưa nếu chưa thì không cho phép tạo chi tiết phiếu nhập
            if (cTDDHBDS.Count == 0)
            {
                MessageBox.Show($"Không thể tạo chi tiết cho phiếu nhập {mAPNTextEdit.Text} này vì đơn đặt hàng {masoDDHTextEdit.Text} chưa có chi tiết", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Gọi tập lệnh của Binding Source;
            cmdManager.prepare(new InsertVTAction(cTPNBDS,"MAVT",true));
            // Khởi động lại các giá trị hiện tại từ phiếu nhập sang chi tiết phiếu nhập


            mAVTTextEdit.Text = cTDDHComboBox.Text;

            vitri2 = cTPNBDS.Position;

            modifyCTUIState();
            enableGroupControl2Input(true);

            //groupControl2.Enabled = false;
            mAPNTextEdit1.Text = mAPNTextEdit.Text;
            insertSession = true;
            sOLUONGSpinEdit.ReadOnly = false;
            dONGIASpinEdit.ReadOnly = false;
            //spinEditMaNV.Value = int.Parse(comboBoxFMaNV.SelectedValue.ToString().Trim());
            //textEditMaKho.Text = comboBoxFMaKho.SelectedValue.ToString().Trim();
            //textEditMaDDH.Text = comboBoxFMaDonDH.SelectedValue.ToString().Trim();
        }

        private void datHangComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                masoDDHTextEdit.Text = datHangComboBox.SelectedValue.ToString();
            }
            catch (Exception nullRef)
            {
                return;
            }
        }

        private void phieuNhapDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // cap nhat combobox dat hang
            datHangBDS.Position = datHangBDS.Find("MasoDDH", ((DataRowView)phieuNhapBDS.Current)["MasoDDH"].ToString());
        }

        private void cTDDHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                 mAVTTextEdit.Text = cTDDHComboBox.SelectedValue.ToString();
               ((DataRowView) cTPNBDS.Current)["MAVT"] = cTDDHComboBox.SelectedValue.ToString();
            }
            catch (Exception nullRef)
            {
                return;
            }
           
        }

        private void saveVTBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            chiTietGroupBox.Focus();
            if (sOLUONGSpinEdit.Text == "")
            {
                MessageBox.Show("Số lượng nhập không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sOLUONGSpinEdit.Focus();
                return;
            }
            if (dONGIASpinEdit.Text == "")
            {
                MessageBox.Show("Đơn giá không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dONGIASpinEdit.Focus();
                return;
            }

            // Kiểm tra tính unique của MasoDDH
            //int checkIndex = BDSCTPN.Find("MAVT", textEditMaVT.Text.Trim());

            // khong kiem tra mavt , do cho chon tu combobox

            int checkIndex = -1;
            for (int i = 0; i < cTPNBDS.Count; i++)
            {
                if (mAVTTextEdit.Text.Trim() == ((DataRowView)cTPNBDS[i])["MAVT"].ToString())
                {
                    checkIndex = i;
                    break;
                }
            }

            if (checkIndex >= 0 && checkIndex != cTPNBDS.Position)
            {
                MessageBox.Show($"Chi tiết phiếu nhập này đã được lập vui lòng chọn lại vât tư khác", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // kiem tra so luong co vuot qua so luong ddh
            int soLuongDDH = Convert.ToInt32(((DataRowView)cTDDHBDS.Current)["SOLUONG"]);
            int soLuongNhap = Convert.ToInt32(((DataRowView)cTPNBDS.Current)["SOLUONG"].ToString());
            if (soLuongNhap > soLuongDDH)
            {
                MessageBox.Show($"Số lượng vật tư nhập vuọt quá ", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // xac nhan
            string mapn = mAPNTextEdit1.Text.Trim();
            string mavt = mAVTTextEdit.Text.Trim();
            try
            {
                cmdManager.commit(); // lay data cho redo
                updateCTPNTableAdapter();
                insertSession = false;
                redoBtn.Enabled = false;
                undoBtn.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            viewUIState();
        }

        private void deleteVTBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (MessageBox.Show("Bạn có thật sự muốn xóa đơn đặt hàng này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                //try
                //{

                    cmdManager.execute(new DeleteVTAction(cTPNBDS, "MAVT", true));
                    // cap nhat so luong vt

                    updateCTPNTableAdapter();
                    undoBtn.Enabled = true;
                    redoBtn.Enabled = false;
            //    }
                //catch (Exception exception)
                //{
                //    MessageBox.Show($"Xóa chi tiết đơn hàng không thành công :3 {exception.Message}", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    this.cTPNTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPN);

                //}

            if (cTPNBDS.Count == 0)
                deleteVTBtn.Enabled = false;
        }


        private void viewUIState()
        {
            phieuNhapGridControl.Enabled = true;
            cTPNGridControl.Enabled = true;

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
            cTPNGridControl.Enabled = false;
            phieuNhapGridControl.Enabled = false;
            saveVTBtn.Enabled = cancelBtn.Enabled = true;
            addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = refreshBtn.Enabled = addVTBtn.Enabled = deleteVTBtn.Enabled = saveBtn.Enabled = undoBtn.Enabled = redoBtn.Enabled = false;
            chiTietGroupBox.Enabled = true;
            thongTinGroupBox.Enabled = false;
        }


        private void modifyUIState()
        {
            cTPNGridControl.Enabled = false;
            phieuNhapGridControl.Enabled = false;
            addBtn.Enabled = updateBtn.Enabled = deleteBtn.Enabled = refreshBtn.Enabled = undoBtn.Enabled = redoBtn.Enabled = false;
            addVTBtn.Enabled = deleteVTBtn.Enabled = saveVTBtn.Enabled = false;
            saveBtn.Enabled = cancelBtn.Enabled = true;
            chiTietGroupBox.Enabled = false;
            thongTinGroupBox.Enabled = true;
        }

        private void phieuNhapGridControl_Click(object sender, EventArgs e) // su dung de cap nhat  dathangbds cho ctpn
        {
            // find vi tri cua row
            String masoddh = ((DataRowView)phieuNhapBDS.Current)["MasoDDH"].ToString();
            int pos = datHangBDS.Find("MasoDDH", masoddh);
            // doi vi tri den row do
            datHangBDS.Position = pos;
        }
    }
}