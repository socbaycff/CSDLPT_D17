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
            this.showPXBtn});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(1628, 229);
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
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 733);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1628, 32);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 765);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.icons8_warehouse_32;
            this.IsMdiContainer = true;
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
    }
}