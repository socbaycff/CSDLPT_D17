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
    public partial class DSVTReportForm : DevExpress.XtraEditors.XtraForm
    {
        XtraReport_DSVT rpt = new XtraReport_DSVT(); // server nao cung nhu nhau 
        public DSVTReportForm()
        {
            InitializeComponent();
        }

        private void showPreviewBtn_Click(object sender, EventArgs e)
        {
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.PreviewForm.SaveState = false;
            print.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            print.ShowPreview();
        }
    }
}