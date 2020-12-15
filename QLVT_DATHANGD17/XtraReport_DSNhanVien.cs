using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT_DATHANGD17
{
    public partial class XtraReport_DSNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_DSNhanVien(String macn)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = macn;
            this.sqlDataSource1.Fill();
        }

    }
}
