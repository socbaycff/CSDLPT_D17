namespace QLVT_DATHANGD17
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.loginBtn = new DevExpress.XtraBars.BarButtonItem();
            this.logOutBtn = new DevExpress.XtraBars.BarButtonItem();
            this.showNVFormBtn = new DevExpress.XtraBars.BarButtonItem();
            this.showVTFormBtn = new DevExpress.XtraBars.BarButtonItem();
            this.showKhoFormBtn = new DevExpress.XtraBars.BarButtonItem();
            this.showDDHFromBtn = new DevExpress.XtraBars.BarButtonItem();
            this.showPNBtn = new DevExpress.XtraBars.BarButtonItem();
            this.showPXBtn = new DevExpress.XtraBars.BarButtonItem();
            this.rpt_dsnv = new DevExpress.XtraBars.BarButtonItem();
            this.rpt_dsvt = new DevExpress.XtraBars.BarButtonItem();
            this.rpt_soLuongTriGia = new DevExpress.XtraBars.BarButtonItem();
            this.roleText = new DevExpress.XtraBars.BarStaticItem();
            this.hotenText = new DevExpress.XtraBars.BarStaticItem();
            this.MaNVText = new DevExpress.XtraBars.BarButtonItem();
            this.rpt_hoatdongNV = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.rpt_ddhChuanhap = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.loginBtn,
            this.logOutBtn,
            this.showNVFormBtn,
            this.showVTFormBtn,
            this.showKhoFormBtn,
            this.showDDHFromBtn,
            this.showPNBtn,
            this.showPXBtn,
            this.rpt_dsnv,
            this.rpt_dsvt,
            this.rpt_soLuongTriGia,
            this.roleText,
            this.hotenText,
            this.MaNVText,
            this.rpt_hoatdongNV,
            this.rpt_ddhChuanhap});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(2);
            this.ribbon.MaxItemId = 20;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(1085, 157);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // loginBtn
            // 
            this.loginBtn.Caption = "Login";
            this.loginBtn.Id = 2;
            this.loginBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.signin;
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.loginBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.loginBtn_ItemClick);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Caption = "LogOut";
            this.logOutBtn.Id = 3;
            this.logOutBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.signout;
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // showNVFormBtn
            // 
            this.showNVFormBtn.Caption = "Nhân Viên";
            this.showNVFormBtn.Id = 4;
            this.showNVFormBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.worker;
            this.showNVFormBtn.Name = "showNVFormBtn";
            this.showNVFormBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.showNVFormBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showNVFormBtn_ItemClick);
            // 
            // showVTFormBtn
            // 
            this.showVTFormBtn.Caption = "Vật Tư";
            this.showVTFormBtn.Id = 5;
            this.showVTFormBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.trolley;
            this.showVTFormBtn.Name = "showVTFormBtn";
            this.showVTFormBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.showVTFormBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showVTFormBtn_ItemClick);
            // 
            // showKhoFormBtn
            // 
            this.showKhoFormBtn.Caption = "Kho";
            this.showKhoFormBtn.Id = 6;
            this.showKhoFormBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.warehouse;
            this.showKhoFormBtn.Name = "showKhoFormBtn";
            this.showKhoFormBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.showKhoFormBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showKhoFormBtn_ItemClick);
            // 
            // showDDHFromBtn
            // 
            this.showDDHFromBtn.Caption = "Đơn đặt hàng";
            this.showDDHFromBtn.Id = 7;
            this.showDDHFromBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.infographic;
            this.showDDHFromBtn.Name = "showDDHFromBtn";
            this.showDDHFromBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.showDDHFromBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showDDHFromBtn_ItemClick);
            // 
            // showPNBtn
            // 
            this.showPNBtn.Caption = "Phiếu nhập";
            this.showPNBtn.Id = 8;
            this.showPNBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.analytics;
            this.showPNBtn.Name = "showPNBtn";
            this.showPNBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.showPNBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showPNBtn_ItemClick);
            // 
            // showPXBtn
            // 
            this.showPXBtn.Caption = "Phiếu Xuất";
            this.showPXBtn.Id = 10;
            this.showPXBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.notes;
            this.showPXBtn.Name = "showPXBtn";
            this.showPXBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.showPXBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showPXBtn_ItemClick);
            // 
            // rpt_dsnv
            // 
            this.rpt_dsnv.Caption = "Danh sách nhân viên";
            this.rpt_dsnv.Id = 11;
            this.rpt_dsnv.Name = "rpt_dsnv";
            this.rpt_dsnv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rpt_dsnv_ItemClick);
            // 
            // rpt_dsvt
            // 
            this.rpt_dsvt.Caption = "Danh sách vật tư";
            this.rpt_dsvt.Id = 12;
            this.rpt_dsvt.Name = "rpt_dsvt";
            this.rpt_dsvt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rpt_dsvt_ItemClick);
            // 
            // rpt_soLuongTriGia
            // 
            this.rpt_soLuongTriGia.Caption = "Số lượng trị giá ";
            this.rpt_soLuongTriGia.Id = 13;
            this.rpt_soLuongTriGia.Name = "rpt_soLuongTriGia";
            this.rpt_soLuongTriGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rpt_soLuongTriGia_ItemClick);
            // 
            // roleText
            // 
            this.roleText.Caption = "Role";
            this.roleText.Id = 15;
            this.roleText.Name = "roleText";
            // 
            // hotenText
            // 
            this.hotenText.Caption = "HOTEN";
            this.hotenText.Id = 16;
            this.hotenText.Name = "hotenText";
            // 
            // MaNVText
            // 
            this.MaNVText.Caption = "MANV";
            this.MaNVText.Id = 17;
            this.MaNVText.Name = "MaNVText";
            // 
            // rpt_hoatdongNV
            // 
            this.rpt_hoatdongNV.Caption = "Hoạt động nhân viên";
            this.rpt_hoatdongNV.Id = 18;
            this.rpt_hoatdongNV.Name = "rpt_hoatdongNV";
            this.rpt_hoatdongNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rpt_hoatdongNV_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Thao tác";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.logOutBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.loginBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.showNVFormBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.showVTFormBtn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.showKhoFormBtn);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.showDDHFromBtn);
            this.ribbonPageGroup6.ItemLinks.Add(this.showPNBtn);
            this.ribbonPageGroup6.ItemLinks.Add(this.showPXBtn);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Báo Cáo";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.rpt_dsnv);
            this.ribbonPageGroup5.ItemLinks.Add(this.rpt_dsvt);
            this.ribbonPageGroup5.ItemLinks.Add(this.rpt_soLuongTriGia);
            this.ribbonPageGroup5.ItemLinks.Add(this.rpt_hoatdongNV);
            this.ribbonPageGroup5.ItemLinks.Add(this.rpt_ddhChuanhap);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.MaNVText);
            this.ribbonStatusBar.ItemLinks.Add(this.hotenText);
            this.ribbonStatusBar.ItemLinks.Add(this.roleText);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 501);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1085, 22);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // rpt_ddhChuanhap
            // 
            this.rpt_ddhChuanhap.Caption = "DDH chưa nhập";
            this.rpt_ddhChuanhap.Id = 19;
            this.rpt_ddhChuanhap.Name = "rpt_ddhChuanhap";
            this.rpt_ddhChuanhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rpt_ddhChuanhap_ItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 523);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.icons8_warehouse_32;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý vật tư";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem loginBtn;
        private DevExpress.XtraBars.BarButtonItem logOutBtn;
        private DevExpress.XtraBars.BarButtonItem showNVFormBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem showVTFormBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem showKhoFormBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem showDDHFromBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem showPNBtn;
        private DevExpress.XtraBars.BarButtonItem showPXBtn;
        private DevExpress.XtraBars.BarButtonItem rpt_dsnv;
        private DevExpress.XtraBars.BarButtonItem rpt_dsvt;
        private DevExpress.XtraBars.BarButtonItem rpt_soLuongTriGia;
        public DevExpress.XtraBars.BarStaticItem roleText;
        public DevExpress.XtraBars.BarStaticItem hotenText;
        public DevExpress.XtraBars.BarButtonItem MaNVText;
        private DevExpress.XtraBars.BarButtonItem rpt_hoatdongNV;
        private DevExpress.XtraBars.BarButtonItem rpt_ddhChuanhap;
    }
}