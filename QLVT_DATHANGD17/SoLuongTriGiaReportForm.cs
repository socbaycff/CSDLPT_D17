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
using DevExpress.XtraReports.UI;

namespace QLVT_DATHANGD17
{
    public partial class SoLuongTriGiaReportForm : DevExpress.XtraEditors.XtraForm
    {
        public SoLuongTriGiaReportForm()
        {
            InitializeComponent();
        }

        private void showPreviewBtn_Click(object sender, EventArgs e)
        {
           

            XtraReport_SoLuongTriGia rpt = new XtraReport_SoLuongTriGia(fromDE.Text, toDE.Text, LoaiCB.Text == "Nhập" ? "N" : "X");
          
            rpt.titleLB.Text = "Bảng kê chi tiết Số lượng - trị giá từ phiếu "+ LoaiCB.Text + " " + fromDE.Text + " đến " + toDE.Text + " theo từng tháng";
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.PreviewForm.SaveState = false;
            print.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            print.ShowPreviewDialog();

        }

        private void SoLuongTriGiaReportForm_Load(object sender, EventArgs e)
        {
            comboBoxBranch.DataSource = Program.bds_dspm;
            comboBoxBranch.DisplayMember = "TENCN";
            comboBoxBranch.ValueMember = "TENSERVER";
            comboBoxBranch.SelectedIndex = Program.mChinhanh;
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
                  //  rpt = new XtraReport_DSNV(Program.connstr);
                    // refreshTableAdapter();
                }
            }
            catch (NullReferenceException nullRef)
            {
                return;
            }
        }
    }
}