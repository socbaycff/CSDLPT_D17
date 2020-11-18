using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT_DATHANGD17
{
    public partial class XtraReport_DSNV : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_DSNV()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }
       

    }
}
