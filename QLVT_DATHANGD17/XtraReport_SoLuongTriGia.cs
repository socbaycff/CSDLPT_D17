using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT_DATHANGD17
{
    public partial class XtraReport_SoLuongTriGia : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_SoLuongTriGia(String from, String to, String loai)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = from;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = to;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = Program.userRole;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = loai;
            this.sqlDataSource1.Fill();

        }

    }
}
