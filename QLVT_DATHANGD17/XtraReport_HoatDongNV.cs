using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT_DATHANGD17
{
    public partial class XtraReport_HoatDongNV : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_HoatDongNV(int maNV, String from, String to)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maNV;
            this.sqlDataSource1.Queries[1].Parameters[0].Value = maNV;
            this.sqlDataSource1.Queries[1].Parameters[1].Value = from;
            this.sqlDataSource1.Queries[1].Parameters[2].Value = to;
            this.sqlDataSource1.Fill();

        }

    }
}
