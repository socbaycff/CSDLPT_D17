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
    public partial class DDHForm : DevExpress.XtraEditors.XtraForm
    {
        public int vitri1;
        public int vitri2;
        public string macn;
        private CommandManager cmdManager;
        private bool insertSession = false;
        public DDHForm()
        {
            InitializeComponent();
            vitri1 = 0;
            vitri2 = 0;
            macn = "";
            cmdManager = new CommandManager();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datHangBDS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void DDHForm_Load(object sender, EventArgs e)
        {
 
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
                addVTBtn.Enabled = deleteVTBtn.Enabled = saveVTBtn.Enabled = false;
            }
            else // Các phân quyền khác như CHINHANH, USER thì không thể lựa chọn chi nhánh khác
            {
                comboBoxBranch.Enabled = false;
                saveBtn.Enabled = cancelBtn.Enabled = false;
                saveVTBtn.Enabled  = false;
            }
            thongTinGroup.Enabled = chiTietGroup.Enabled = false;
            masoDDHTE1.ReadOnly = true;
            mAVTTextEdit.ReadOnly = true;
            mANVSpinEdit.ReadOnly = true;
            mAKHOTextEdit.ReadOnly = true;
        }

        private void updateDHTableAdapter()
        {
            //
            datHangBDS.EndEdit();
            datHangBDS.ResetCurrentItem();
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Update(qLVT_DATHANGDataSet.DatHang);
            //
            ctddhBDS.EndEdit();
            ctddhBDS.ResetCurrentItem();
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Update(qLVT_DATHANGDataSet.CTDDH);
        }
        private void updateCTDDHTableAdapter()
        {
            ctddhBDS.EndEdit();
            ctddhBDS.ResetCurrentItem();
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Update(qLVT_DATHANGDataSet.CTDDH);
        }

        private void addVTBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri2 = ctddhBDS.Position;
           
            // Vô hiẹu hóa phần /Grid Control của đơn đặt hàng
            cTDDHGridControl.Enabled = false;
            datHangGridControl.Enabled = false;
            // Gọi tập lệnh của Binding Source;
            cmdManager.execute(new InsertAction(ctddhBDS));
            saveVTBtn.Enabled = cancelBtn.Enabled = true;
            addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = refreshBtn.Enabled = addVTBtn.Enabled = deleteVTBtn.Enabled = saveBtn.Enabled = undoBtn.Enabled = false;
            // Mở phần chỉnh sửa
            chiTietGroup.Enabled = true;
            thongTinGroup.Enabled = false;
            mAVTTextEdit.ReadOnly = false;
            // Tự động điền các mã đơn đặt hàng hiện tại và mã vật tư
            masoDDHTE1.Text = masoDDHTE.Text;
         //   textEditMaVT.Text = comboBoxPackageName.SelectedValue.ToString().Trim(); dong nay xu ly sau
        }

        private void refreshTableAdapter()
        {
            // TODO: This line of code loads data into the 'DS.DATHANG' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);
            // TODO: This line of code loads data into the 'DS.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTDDH);
            // TODO: This line of code loads data into the 'DS.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuNhap);
            // TODO: This line of code loads data into the 'DS.VATTU' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet.Vattu);
            // TODO: This line of code loads data into the 'DS.KHO' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);
            // TODO: This line of code loads data into the 'DS.SP_InDanhSachNhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
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

        private void deleteVTBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
        
            if (MessageBox.Show("Bạn có thật sự muốn xóa đơn đặt hàng này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                try
                {

                    cmdManager.execute(new DeleteAction(ctddhBDS));
                    updateCTDDHTableAdapter();
                    undoBtn.Enabled = true;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Xóa chi tiết đơn hàng không thành công :3", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTDDH);

                }

            if (ctddhBDS.Count == 0)
                deleteVTBtn.Enabled = false;
        }

        private void saveVTBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            chiTietGroup.Focus();

            if (soLuongSE.Text.Trim() == "" || soLuongSE.Value < 0)
            {
                MessageBox.Show("Số lượng đặt không được để trống và phải có giá trị dương", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                soLuongSE.Focus();
                return;
            }
            if (donGiaSE.Text.Trim() == "" || donGiaSE.Value < 0)
            {
                MessageBox.Show("Đơn giá của vật tư không được để trống và phải có giá trị dương", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                donGiaSE.Focus();
                return;
            }
            // check mavt 
            if (vatTuBDS.Find("MAVT", mAVTTextEdit.Text.Trim()) == -1) {
                MessageBox.Show("Mã vật tư không tồn tại", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mAVTTextEdit.Focus();
                return;
            }
            try
            {
                // check mavt co da co chua
                int checkIndex = -1;
                for (int i = 0; i < ctddhBDS.Count; i++)
                {
                    if (mAVTTextEdit.Text.Trim() == ((DataRowView)ctddhBDS[i])["MAVT"].ToString())
                    {
                        checkIndex = i;
                        break;
                    }
                }
               
                if (checkIndex >= 0 && checkIndex != ctddhBDS.Position)
                {
                    MessageBox.Show($"Chi tiết cho vật tư này đã được lập vui lòng chọn lại vât tư khác", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // chua kt ma vt ton tai
                ((InsertAction)cmdManager.getLastUndoNode()).getData(); // lay data cho redo
                updateCTDDHTableAdapter();
                undoBtn.Enabled = true;
                // Tùy chỉnh lại trạng thái các button sau khi hoàn tất
                datHangGridControl.Enabled = true;
                cTDDHGridControl.Enabled = true;

                addBtn.Enabled = updateBtn.Enabled = deleteBtn.Enabled = refreshBtn.Enabled = true;
                addVTBtn.Enabled = deleteVTBtn.Enabled = true;
                saveBtn.Enabled = cancelBtn.Enabled = false;
                saveVTBtn.Enabled = false;
                thongTinGroup.Enabled = false;
                chiTietGroup.Enabled = false;
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

                datHangBDS.CancelEdit();
                ctddhBDS.CancelEdit();
                insertSession = false;
            }
     
            datHangGridControl.Enabled = true;
            cTDDHGridControl.Enabled = true;
            thongTinGroup.Enabled = false;
            chiTietGroup.Enabled = false;

            addBtn.Enabled = updateBtn.Enabled = deleteBtn.Enabled = refreshBtn.Enabled = true;
            addVTBtn.Enabled = deleteVTBtn.Enabled = true;
            saveBtn.Enabled = false;
            saveVTBtn.Enabled = cancelBtn.Enabled = false;

            refreshBtn.PerformClick();
            ctddhBDS.Position = vitri2;
            datHangBDS.Position = vitri1;
            cmdManager.clearLastNode();
            if (cmdManager.undoStackSize() == 0)
            {
                undoBtn.Enabled = false;
            }
        }

        private void undoBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            cmdManager.undo();
            updateDHTableAdapter();
            updateCTDDHTableAdapter();
            redoBtn.Enabled = true;
            if (cmdManager.undoStackSize() == 0)
            {
                undoBtn.Enabled = false;
            }
        }

        private void redoBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            cmdManager.redo();
            updateDHTableAdapter();
            updateCTDDHTableAdapter();
            if (cmdManager.redoStackSize() == 0)
            {
                redoBtn.Enabled = false;
            }
            undoBtn.Enabled = true;
        }

        private void addBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri1 = datHangBDS.Position;
            // Vô hiẹu hóa phần /Grid Control của đơn đặt hàng
            datHangGridControl.Enabled = false;
            // Gọi tập lệnh của Binding Source;
            cmdManager.execute(new InsertAction(datHangBDS));
            saveBtn.Enabled = cancelBtn.Enabled = true;
            addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = refreshBtn.Enabled = addVTBtn.Enabled = deleteVTBtn.Enabled = saveVTBtn.Enabled =  false;
            // Mở phần chỉnh sửa
            thongTinGroup.Enabled = true;
            chiTietGroup.Enabled = false;
            masoDDHTE.ReadOnly = false;
            mANVSpinEdit.ReadOnly = false;
            mAKHOTextEdit.ReadOnly = false;
            insertSession = true;
        }

        private void saveBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            thongTinGroup.Focus();
            if (masoDDHTE.Text.Trim() == "")
            {
                MessageBox.Show("Mã đơn đặt hàng không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                masoDDHTE.Focus();
                return;
            }
            //-----------------------------------------------------------
            if (nGAYDateEdit.Text.Trim() == "")
            {
                MessageBox.Show("Ngày lập đơn không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nGAYDateEdit.Focus();
                return;
            }
            if (nhaCCTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Nhà cung cấp không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nhaCCTextEdit.Focus();
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
                    string command = $"exec SP_TimDDH '{masoDDHTE.Text.Trim()}'";
                    Program.myReader = Program.ExecSqlDataReader(command);
                    if (Program.myReader != null)
                    {
                        MessageBox.Show(command);
                        Program.myReader.Read();
                        MessageBox.Show($"Đơn đặt hàng đã được lập vào: {Program.myReader.GetDateTime(0)}");
                        Program.myReader.Close();
                        return;
                    }
                    else {
                        ((InsertAction)cmdManager.getLastUndoNode()).getData(); // lay data cho redo
                        insertSession = false;
                        updateDHTableAdapter();
                        
                    }
                    
                } else
                {
                    ((UpdateAction)cmdManager.getLastUndoNode()).getData(); // lay data cho redo
                    updateDHTableAdapter();
                }
                
                // Tùy chỉnh lại trạng thái các button sau khi hoàn tất
                datHangGridControl.Enabled = true;
                cTDDHGridControl.Enabled = true;

                addBtn.Enabled = updateBtn.Enabled = deleteBtn.Enabled = refreshBtn.Enabled = true;
                addVTBtn.Enabled = deleteVTBtn.Enabled = true;
                saveBtn.Enabled = cancelBtn.Enabled = false;
                saveBtn.Enabled = false;
                thongTinGroup.Enabled = false;
                mANVSpinEdit.ReadOnly = true;
                mAKHOTextEdit.ReadOnly = true;
                undoBtn.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void deleteBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ctddhBDS.Count > 0 || phieuNhapBDS.Count > 0)
                MessageBox.Show($" Đơn hàng {masoDDHTE.Text} không thể xóa :3", "Lỗi xóa đơn đặt hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string delMaDDH = "";
                if (MessageBox.Show("Bạn có thật sự muốn xóa đơn đặt hàng này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    try
                    {
                        delMaDDH = ((DataRowView)datHangBDS[datHangBDS.Position])["MasoDDH"].ToString();
                        cmdManager.execute(new DeleteAction(datHangBDS));
                        this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.datHangTableAdapter.Update(this.qLVT_DATHANGDataSet.DatHang);
                        undoBtn.Enabled = true;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Xóa nhân viên không thành công :3", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);
                        datHangBDS.Position = datHangBDS.Find("MasoDDH", delMaDDH);
                    }
            }
            if (datHangBDS.Count == 0)
                deleteBtn.Enabled = false;
        }

        private void updateBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
           
            vitri1 = datHangBDS.Position;
            cmdManager.execute(new UpdateAction(datHangBDS));
            thongTinGroup.Enabled = true;
            addBtn.Enabled = updateBtn.Enabled = deleteBtn.Enabled = refreshBtn.Enabled = false;
            addVTBtn.Enabled = deleteVTBtn.Enabled = cancelBtn.Enabled = saveVTBtn.Enabled = false;
            saveBtn.Enabled = cancelBtn.Enabled = true;
            datHangGridControl.Enabled = false;
            masoDDHTE.ReadOnly = true;
            mANVSpinEdit.ReadOnly = false;
            mAKHOTextEdit.ReadOnly = false;

        }

        private void refreshBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                datHangBDS.RemoveFilter();
                ctddhBDS.RemoveFilter();
                refreshTableAdapter();
            }
            catch (Exception exception)
            {
                MessageBox.Show($" <3 {exception.Message}", "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ctddhBDS.Count > 0)
            {
                deleteVTBtn.Enabled = true;
            }
            else
            {
                deleteVTBtn.Enabled = false;
            }
        }
    }
}