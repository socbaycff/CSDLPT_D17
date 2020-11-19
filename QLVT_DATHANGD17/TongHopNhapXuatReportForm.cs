using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace QLVT_DATHANGD17
{
    public partial class TongHopNhapXuatReportForm : DevExpress.XtraEditors.XtraForm
    {
        public TongHopNhapXuatReportForm()
        {
            InitializeComponent();
        }

        private void showPreviewBtn_Click(object sender, EventArgs e)
        {
            XtraReport_TongHopNX rpt = new XtraReport_TongHopNX(fromDE.Text, toDE.Text);
            rpt.dateTitle.Text = "TỪ "+ fromDE.Text + " ĐẾN " + toDE.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
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

                }
            }
            catch (NullReferenceException nullRef)
            {
                return;
            }
        }

        private void TongHopNhapXuatReportForm_Load(object sender, EventArgs e)
        {
            comboBoxBranch.DataSource = Program.bds_dspm;
            comboBoxBranch.DisplayMember = "TENCN";
            comboBoxBranch.ValueMember = "TENSERVER";
            comboBoxBranch.SelectedIndex = Program.mChinhanh;
        }
    }
}