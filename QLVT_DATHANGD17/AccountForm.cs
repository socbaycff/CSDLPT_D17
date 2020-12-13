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
    public partial class AccountForm : DevExpress.XtraEditors.XtraForm
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void deleteBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa tài khoản này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                // lay login name/ username tu dong dc user chon
                string loginName = ((DataRowView)sP_DANH_SACH_ACCBindingSource.Current)["LOGINNAME"].ToString();
                string username = ((DataRowView)sP_DANH_SACH_ACCBindingSource.Current)["MANV"].ToString();
                // goi sp delete
                // Thực thi SP tạo login

                //  cam xoa tai khoan dang login
                if (loginName == Program.mloginDN) // k cho xoa nhung van cho hien de biet dc co tao acc
                {
                    MessageBox.Show("Không thể xóa tài khoản đang đăng nhập", "Xóa thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    string command = $"exec Xoa_Login '{loginName}', '{username}'";
                   // MessageBox.Show(command);
                    Program.myReader = Program.ExecSqlDataReader(command);
                    if (Program.myReader != null)
                    {
                        MessageBox.Show($"Xóa tài khoản thành công", "Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // tat box grid insert
                        groupBox1.Enabled = false;
                        sP_DANH_SACH_ACCGridControl.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản đăng nhập thất bại", "Xóa thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // refresh
                    refreshTableAdapter();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                if (Program.myReader != null)
                {
                    Program.myReader.Close();
                }
            }
            
        }

        private void insertBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            // bat box cho insert
            groupBox1.Enabled = true;
            sP_DANH_SACH_ACCGridControl.Enabled = false;
            // cho phep tao acc voi cac quyen nhat dinh
            if (Program.userRole == "CongTy")
            {
                chiNhanhRadio.Enabled = false;
                userRadio.Enabled = false;
                congTyRadio.Checked = true;
            }
            else { // chi nhanh dc tao 2 loai acc
                congTyRadio.Enabled = false;
                userRadio.Checked = true;
            }
            
        
        }
        private void enableAllRadio() {
            chiNhanhRadio.Enabled = true;
            userRadio.Enabled = true;
            congTyRadio.Enabled = true;
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
     

            qLVT_DATHANGDataSet.EnforceConstraints = false;
            // dung quyen owner 
            Program.mlogin = "sa";
            Program.password = "1234";
            refreshTableAdapter();
            // Sao chép danh sách phân mảnh + server tương ứng lấy khi đăng nhập
            comboBoxBranch.DataSource = Program.bds_dspm;
            comboBoxBranch.DisplayMember = "TENCN";
            comboBoxBranch.ValueMember = "TENSERVER";
            comboBoxBranch.SelectedIndex = Program.mChinhanh;

        }

        private void refreshTableAdapter()
        {

            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.SP_NV_CHUA_TAO_ACC' table. You can move, or remove it, as needed.
            this.sP_NV_CHUA_TAO_ACCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_NV_CHUA_TAO_ACCTableAdapter.Fill(this.qLVT_DATHANGDataSet.SP_NV_CHUA_TAO_ACC);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.SP_DANH_SACH_ACC' table. You can move, or remove it, as needed.
            this.sP_DANH_SACH_ACCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DANH_SACH_ACCTableAdapter.Fill(this.qLVT_DATHANGDataSet.SP_DANH_SACH_ACC);
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxBranch.SelectedValue.ToString() == "System.Data.DataRowView")
                    return;
                // Gán chi nhánh mới
                Program.servername = comboBoxBranch.SelectedValue.ToString();
                // Dùng SUPPORT_CONNECT để kết nối tới server mới thay cho login cũ nếu như thay đổi chi nhánh mới trên comboBoxBranch
                if (Program.mChinhanh != comboBoxBranch.SelectedIndex)
                {
                    Program.mlogin = "sa";
                    Program.password = "1234";
                }
                // Dung tài khoản khi đăng nhập nếu như chọn lại chi nhánh chọn khi đăng nhập
                else
                {
                    Program.mlogin = "sa";
                    Program.password = "1234";
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
            refreshTableAdapter();
        }

        private void addNewAccountBtn_Click(object sender, EventArgs e)
        {
            // chuyen chi nhanh xu ly sau
            //if (int.Parse(comboBoxUserName.Text.Trim()) < 0)
            //{
            //    MessageBox.Show("Không thể tạo tài khoản đăng nhập cho nhân viên đã chuyển chi nhánh", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            if (loginNameTE.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginNameTE.Focus();
                return;
            }
            if (passwordTE.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTE.Focus();
                return;
            }
            // khong can check radio button vi da check default 

            // Thực thi SP tạo login
            try
            {

                // lay role dc chon
                string role = "";
                if (congTyRadio.Checked)
                {
                    role = "CongTy";
                }
                else if (chiNhanhRadio.Checked)
                {
                    role = "ChiNhanh";
                }
                else {
                    role = "User";
                }
                string command = $"exec SP_TAOLOGIN '{loginNameTE.Text.Trim()}', '{passwordTE.Text}', '{maNVCB.Text}', '{role}'";
              //  MessageBox.Show(command);
                Program.myReader = Program.ExecSqlDataReader(command);
                if (Program.myReader != null)
                {
                    MessageBox.Show($"Tạo tài khoản thành công với tên đăng nhập là {loginNameTE.Text.Trim()}", "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // tat box grid insert
                    groupBox1.Enabled = false;
                    sP_DANH_SACH_ACCGridControl.Enabled = true;
                    return;
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản đăng nhập thất bại, hãy kiểm tra lại tên đăng nhập và mã nhân viên", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                

            }
            if (Program.myReader != null) {
                Program.myReader.Close();
            }
          
            refreshTableAdapter();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            sP_DANH_SACH_ACCGridControl.Enabled = true;
            enableAllRadio();
        }
    }
}