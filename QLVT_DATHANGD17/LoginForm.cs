using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLVT_DATHANGD17
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANG_DSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANG_DSPM.V_DS_PHANMANH);
            comboBoxSVName.SelectedIndex = 0;
            Program.servername = comboBoxSVName.SelectedValue.ToString();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (loginNameTB.Text == "" || passwordTB.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để đăng nhập", "LỖI ĐĂNG NHẬP", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                Program.mlogin = loginNameTB.Text;
                Program.password = passwordTB.Text;
                //MessageBox.Show(Program.mlogin + " " + Program.password + " " + Program.servername);
                // Lấy thông tin các ds phân mảnh về 1 lần, lưu lại trong biến bds_dspm để sử dụng cho các form khác
                Program.bds_dspm = this.BDS_View_DSPM;
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;
                if (Program.KetNoi() == false) return;
                else
                {
                    //MessageBox.Show("Kết nối thành công");
                    // Ghi lại index của chi nhánh được chọn lúc đăng nhập
                    Program.mChinhanh = comboBoxSVName.SelectedIndex;

                    string command = "exec SP_DANGNHAP '" + Program.mlogin + "'";
                    Program.myReader = Program.ExecSqlDataReader(command);
                    if (Program.myReader == null)
                        return;
                    if (Program.myReader.Read())
                    {
                        Program.userID = Program.myReader.GetString(0);
                        if (Convert.IsDBNull(Program.userID))
                        {
                            MessageBox.Show("Login hiện tại không có quyền truy cập vào database", "Lỗi quyền truy cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        Program.userName = Program.myReader.GetString(1);
                        Program.userRole = Program.myReader.GetString(2);
                       // MessageBox.Show($"{Program.userName} {Program.userRole} {Program.userID}");
                        Program.myReader.Close();
                        Program.conn.Close();
                    }



                    //// Hiện thông tin người làm việc hiện tại trên thanh status bar của Main Form
                    this.Hide();
                    //Program.mainForm.LoginState = CurrentSessionState.Activated;
                    StaffForm staffForm = new StaffForm();
                    staffForm.MdiParent = Program.mainForm;
                    staffForm.Show();
                }

            }
        }

        private void comboBoxSVName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = comboBoxSVName.SelectedValue.ToString();
            }
            catch (NullReferenceException nullRef)
            {
                return;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
                loginBtn.PerformClick();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}