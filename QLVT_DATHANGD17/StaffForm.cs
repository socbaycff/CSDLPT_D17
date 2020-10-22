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
    public partial class StaffForm : DevExpress.XtraEditors.XtraForm
    {
        public int vitri;
        public string macn;
        public StaffForm()
        {
            InitializeComponent();
            vitri = 0;
            macn = "";
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBDS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            detailGroup.Enabled = false;
            this.chiNhanhTableAdapter.Fill(this.qLVT_DATHANGDataSet.ChiNhanh);
            qLVT_DATHANGDataSet.EnforceConstraints = false;
            refreshTable();
            comboBoxBranch.DataSource = Program.bds_dspm;
            comboBoxBranch.DisplayMember = "TENCN";
            comboBoxBranch.ValueMember = "TENSERVER";
            comboBoxBranch.SelectedIndex = Program.mChinhanh;

            if (Program.userRole == "CONGTY")
            {
                comboBoxBranch.Enabled = true;
                detailGroup.Enabled = false;updateBtn.Enabled = saveBtn.Enabled = undoBtn.Enabled = exchangeBtn.Enabled = false;
            }
            else // Các phân quyền khác như CHINHANH, USER thì không thể lựa chọn chi nhánh khác
            {
                comboBoxBranch.Enabled = false;
                //groupBox1.Enabled = false;
                detailGroup.Enabled = false;
                exchangeGroup.Enabled = false;
                saveBtn.Enabled = undoBtn.Enabled = false;
            }
            macn = ((DataRowView)chiNhanhBDS[0])["MACN"].ToString();

            //   textEditMaCN.ReadOnly = true;
            luongSpin.Properties.MinValue = 4000000;
            luongSpin.Properties.MaxValue = 1000000000;
            hoTE.Properties.MaxLength = 40;
            tenTE.Properties.MaxLength = 10;
            diaChiTE.Properties.MaxLength = 100;
           // textEditMaCN.Properties.MaxLength = 10;
            //textBoxTenCNHienTai.Text = comboBoxBranch.Text;
            //textBoxTenCNHienTai.ReadOnly = true;
        }

        private void refreshTable() {
            // cap nhat connection string + load lai cac bang
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuXuat);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuNhap);
            
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);

            // load danh sach phan manh
        //    this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANG_DSPM.V_DS_PHANMANH);

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
                    refreshTable();
                    // Lấy mã chi nhánh hiện tại
                 //   macn = ((DataRowView)chiNhanhBDS[0])["MACN"].ToString();
                 //   MessageBox.Show(macn);
                }
            }
            catch (NullReferenceException nullRef)
            {
                return;
            }
        }

        private void addBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri = nhanVienBDS.Position;
            // lastPressed = LastPressedButton.ButtonAddNew;
            // 
            detailGroup.Enabled = true;
            exchangeGroup.Enabled = false;
            // Gọi tập lệnh của Binding Source, bất chế độ chỉnh sửa BDS
            nhanVienBDS.AddNew();
            ModifyUIState();
            // Vô hiệu hóa phần xem grid
            nhanVienDataGridView.Enabled = false;
            // Cho phép nhập mới mã nhân viên và mà chi nhánh
            maNVSpin.Enabled = true;
            maCNTE.Text = macn;
            MessageBox.Show(maCNTE.Text);
        }

        private void ModifyUIState()
        {
            saveBtn.Enabled = undoBtn.Enabled = true;
            addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = refreshBtn.Enabled = exchangeBtn.Enabled = false;
        }

        private void ViewUIState()
        {
            saveBtn.Enabled = undoBtn.Enabled = false;
            addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = refreshBtn.Enabled = exchangeBtn.Enabled = true;
        }

        private void startChangingBranchMode()
        {
            saveBtn.Enabled = undoBtn.Enabled = exchangeBtn.Enabled = false;
            addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = refreshBtn.Enabled = false;
        }

        private void saveBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            //switch (lastPressed)
            //{
            //    case LastPressedButton.ButtonAddNew:
            //        lastPressed = LastPressedButton.ButtonAddNew_CheckError;
            //        break;
            //    case LastPressedButton.ButtonModify:
            //        lastPressed = LastPressedButton.ButtonModify_CheckError;
            //        break;
            //}
            if (maNVSpin.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maNVSpin.Focus();
                return;
            }
            //if (lastPressed == LastPressedButton.ButtonAddNew_CheckError && (int)spinEditMaNV.Value < 0)
            //{
            //    MessageBox.Show("Mã nhân viên âm chỉ đuọc phép sử dụng cho nhân viên đã chuyển chi nhánh, hãy chọn một mã khác", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    spinEditMaNV.Focus();
            //    return;
            //}
            if ( (int)maNVSpin.Value < 0)
            {
                MessageBox.Show("Mã nhân viên âm chỉ đuọc phép sử dụng cho nhân viên đã chuyển chi nhánh, hãy chọn một mã khác", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maNVSpin.Focus();
                return;
            }
            //-----------------------------------------------------------
            if (hoTE.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hoTE.Focus();
                return;
            }
            if (tenTE.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tenTE.Focus();
                return;
            }
            if (diaChiTE.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ nhân viên không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                diaChiTE.Focus();
                return;
            }
            if (ngaySinhDE.Text.Trim() == "")
            {
                MessageBox.Show("Ngày sinh nhân viên không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ngaySinhDE.Focus();
                return;
            }
            if (luongSpin.Text.Trim() == "" || luongSpin.Value < 4000000)
            {
                MessageBox.Show("Lương nhân viên không chính xác", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                luongSpin.Focus();
                return;
            }
            //if (textEditMaCN.Text.Trim() == "")
            //{
            //    MessageBox.Show("Mã chi nhánh không được bỏ trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    textEditMaCN.Focus();
            //    return;
            //}
            //if (textEditMaCN.Text.Trim() != macn.Trim())
            //{
            //    MessageBox.Show($"Mã chi nhánh không chính xác đối với chi nhánh hiện tại, bạn nên sửa lại thành {macn}", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    textEditMaCN.Text = macn;
            //    textEditMaCN.Focus();
            //    return;
            //}
            // Goi sp tim ma nhan vien
            //MessageBox.Show(spinEditMaNV.Text.ToString().Trim('.'));
            try
            {
                //if (lastPressed == LastPressedButton.ButtonAddNew || lastPressed == LastPressedButton.ButtonAddNew_CheckError)
                //{
                    //string command = "exec sp_TimNV " + maNVSpin.Text.ToString().Trim('.');
                    //Program.myReader = Program.ExecSqlDataReader(command);
                    //if (Program.myReader != null)
                    //{
                    //    Program.myReader.Read();

                    //    MessageBox.Show($"Mã nhân viên đã tồn tại với thông tin: {Program.myReader.GetString(0)} {Program.myReader.GetString(1)} - {Program.myReader.GetString(2)}");
                    //    Program.myReader.Close();
                    //    //lastPressed = LastPressedButton.ButtonAddNew_CheckError;
                    //    return;
                    //}
        //        }
                // Cập nhật xuống database
                updateTableAdapter();
                // Tùy chỉnh lại trạng thái các button sau khi hoàn tất
                ViewUIState();
                nhanVienDataGridView.Enabled = true;
                detailGroup.Enabled = false;
                exchangeGroup.Enabled = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void updateTableAdapter()
        {
            ((DataRowView)nhanVienBDS.Current)["MACN"] = macn; // set chi nhanh la chi nhanh server dang nhap
            nhanVienBDS.EndEdit();
            nhanVienBDS.ResetCurrentItem();
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Update(this.qLVT_DATHANGDataSet.NhanVien);

        }
    }
}