﻿using System;
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
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            showLoginForm();
            this.WindowState = FormWindowState.Maximized;
         //   this.MinimumSize = this.Size;
          //  this.MaximumSize = this.Size;
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form childForm in this.MdiChildren)
                if (childForm.GetType() == ftype)
                    return childForm;
            return null;
        }

        public void showLoginForm()
        {
            Form form = this.CheckExists(typeof(LoginForm));
            if (form != null) form.Focus();
            else
            {
                LoginForm newForm = new LoginForm();
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void loginBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoginForm();
        }

        private void showNVFormBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(NhanVienForm));
            if (form != null) {
                form.Focus();
            } 
            else
            {
                NhanVienForm newForm = new NhanVienForm();
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void showVTFormBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(VatTuForm));
            if (form != null) form.Focus();
            else
            {
                VatTuForm newForm = new VatTuForm();
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void showKhoFormBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(KhoForm));
            if (form != null) form.Focus();
            else
            {
                KhoForm newForm = new KhoForm();
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void showDDHFromBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(DDHForm));
            if (form != null) form.Focus();
            else
            {
                DDHForm newForm = new DDHForm();
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void showPNBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(PhieuNhapForm));
            if (form != null) form.Focus();
            else
            {
                PhieuNhapForm newForm = new PhieuNhapForm();
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void showPXBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(PhieuXuatForm));
            if (form != null) form.Focus();
            else
            {
                PhieuXuatForm newForm = new PhieuXuatForm();
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void rpt_dsnv_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(DSNVReportForm));
            if (form != null) form.Focus();
            else
            {
                DSNVReportForm newForm = new DSNVReportForm();
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void rpt_dsvt_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(DSVTReportForm));
            if (form != null) form.Focus();
            else
            {
                DSVTReportForm newForm = new DSVTReportForm();
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void rpt_soLuongTriGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(SoLuongTriGiaReportForm));
            if (form != null) form.Focus();
            else
            {
                SoLuongTriGiaReportForm newForm = new SoLuongTriGiaReportForm();
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void rpt_hoatdongNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(HoatDongNVReportForm));
            if (form != null) form.Focus();
            else
            {
                HoatDongNVReportForm newForm = new HoatDongNVReportForm();
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void rpt_ddhChuanhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(DDHChuaNhapReportForm));
            if (form != null) form.Focus();
            else
            {
                DDHChuaNhapReportForm newForm = new DDHChuaNhapReportForm();
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void rpt_tonghop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(TongHopNhapXuatReportForm));
            if (form != null) form.Focus();
            else
            {
                TongHopNhapXuatReportForm newForm = new TongHopNhapXuatReportForm();
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void showAccFormBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(AccountForm));
            if (form != null) form.Focus();
            else
            {
                AccountForm newForm = new AccountForm();
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void logOutBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            Program.mainForm.roleText.Caption = "Role";
            Program.mainForm.hotenText.Caption = "Username";
            Program.mainForm.MaNVText.Caption = "MANV";
            Form form = this.CheckExists(typeof(LoginForm));
            if (form != null) form.Focus();
            else
            {
                LoginForm newForm = new LoginForm();
                newForm.MdiParent = this;
                newForm.Show();
            }
            Program.mainForm.SignedOutState();
        }


        public void SignedInState() {
            showNVFormBtn.Enabled = showVTFormBtn.Enabled = phieuRibbon.Enabled = showKhoFormBtn.Enabled = true;
            if (Program.userRole == "CongTy" || Program.userRole == "ChiNhanh") { // role cong ty moi xem dc bao cao
                baocaoribbon.Enabled = true;
            }
            if (Program.userRole == "User")
            {
                showAccFormBtn.Enabled = false;
            }
            else {
                showAccFormBtn.Enabled = true;
            }
        }

        public void SignedOutState()
        {
            showNVFormBtn.Enabled = showVTFormBtn.Enabled = phieuRibbon.Enabled = showKhoFormBtn.Enabled = showAccFormBtn.Enabled = false;
            baocaoribbon.Enabled = false;


        }

       
    }
}