namespace QLVT_DATHANGD17
{
    partial class KhoForm
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
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label dIACHILabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.updateBtn = new DevExpress.XtraBars.BarButtonItem();
            this.saveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.cancelBtn = new DevExpress.XtraBars.BarButtonItem();
            this.undoBtn = new DevExpress.XtraBars.BarButtonItem();
            this.redoBtn = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.diaChiTE = new DevExpress.XtraEditors.TextEdit();
            this.khoBDS = new System.Windows.Forms.BindingSource(this.components);
            this.qLVT_DATHANGDataSet = new QLVT_DATHANGD17.QLVT_DATHANGDataSet();
            this.tenKhoTE = new DevExpress.XtraEditors.TextEdit();
            this.maKhoTE = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.khoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.khoTableAdapter = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.datHangTableAdapter = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter();
            this.phieuNhapTableAdapter = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter();
            this.phieuXuatTableAdapter = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.PhieuXuatTableAdapter();
            this.datHangBDS = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapBDS = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatBDS = new System.Windows.Forms.BindingSource(this.components);
            this.chiNhanhBDS = new System.Windows.Forms.BindingSource(this.components);
            this.chiNhanhTableAdapter = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.ChiNhanhTableAdapter();
            mAKHOLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKhoTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKhoTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBDS)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(131, 55);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(61, 19);
            mAKHOLabel.TabIndex = 0;
            mAKHOLabel.Text = "Mã Kho";
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Location = new System.Drawing.Point(124, 112);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(68, 19);
            tENKHOLabel.TabIndex = 2;
            tENKHOLabel.Text = "Tên Kho";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(503, 55);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(57, 19);
            dIACHILabel.TabIndex = 4;
            dIACHILabel.Text = "Địa chỉ";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addBtn,
            this.deleteBtn,
            this.updateBtn,
            this.saveBtn,
            this.cancelBtn,
            this.undoBtn,
            this.redoBtn,
            this.refreshBtn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.addBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.updateBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.saveBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.cancelBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.undoBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.redoBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.refreshBtn)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // addBtn
            // 
            this.addBtn.Caption = "Thêm";
            this.addBtn.Id = 0;
            this.addBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.add;
            this.addBtn.Name = "addBtn";
            this.addBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.addBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBtn_ItemClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Xóa";
            this.deleteBtn.Id = 1;
            this.deleteBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.remove__2_;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
            // 
            // updateBtn
            // 
            this.updateBtn.Caption = "Sửa";
            this.updateBtn.Id = 2;
            this.updateBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.international;
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.updateBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.updateBtn_ItemClick);
            // 
            // saveBtn
            // 
            this.saveBtn.Caption = "Lưu";
            this.saveBtn.Id = 3;
            this.saveBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources._checked;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.saveBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveBtn_ItemClick);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Caption = "Hủy";
            this.cancelBtn.Id = 4;
            this.cancelBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.remove__3_;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.cancelBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cancelBtn_ItemClick);
            // 
            // undoBtn
            // 
            this.undoBtn.Caption = "Undo";
            this.undoBtn.Enabled = false;
            this.undoBtn.Id = 5;
            this.undoBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.back_arrow_solid_square_button;
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.undoBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.undoBtn_ItemClick);
            // 
            // redoBtn
            // 
            this.redoBtn.Caption = "Redo";
            this.redoBtn.Enabled = false;
            this.redoBtn.Id = 6;
            this.redoBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.image;
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.redoBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.redoBtn_ItemClick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Caption = "Refresh";
            this.refreshBtn.Id = 7;
            this.refreshBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.refreshing1;
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.refreshBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBtn_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1472, 63);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 792);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1472, 19);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 63);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 729);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1472, 63);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 729);
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(1008, 16);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(269, 27);
            this.comboBoxBranch.TabIndex = 0;
            this.comboBoxBranch.SelectedIndexChanged += new System.EventHandler(this.comboBoxBranch_SelectedIndexChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 591);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1472, 201);
            this.panelControl1.TabIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(dIACHILabel);
            this.groupControl1.Controls.Add(this.diaChiTE);
            this.groupControl1.Controls.Add(tENKHOLabel);
            this.groupControl1.Controls.Add(this.tenKhoTE);
            this.groupControl1.Controls.Add(mAKHOLabel);
            this.groupControl1.Controls.Add(this.maKhoTE);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1468, 197);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin chi tiết";
            // 
            // diaChiTE
            // 
            this.diaChiTE.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBDS, "DIACHI", true));
            this.diaChiTE.Location = new System.Drawing.Point(579, 52);
            this.diaChiTE.MenuManager = this.barManager1;
            this.diaChiTE.Name = "diaChiTE";
            this.diaChiTE.Size = new System.Drawing.Size(446, 28);
            this.diaChiTE.TabIndex = 5;
            // 
            // khoBDS
            // 
            this.khoBDS.DataMember = "Kho";
            this.khoBDS.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenKhoTE
            // 
            this.tenKhoTE.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBDS, "TENKHO", true));
            this.tenKhoTE.Location = new System.Drawing.Point(207, 109);
            this.tenKhoTE.MenuManager = this.barManager1;
            this.tenKhoTE.Name = "tenKhoTE";
            this.tenKhoTE.Size = new System.Drawing.Size(229, 28);
            this.tenKhoTE.TabIndex = 3;
            // 
            // maKhoTE
            // 
            this.maKhoTE.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBDS, "MAKHO", true));
            this.maKhoTE.Location = new System.Drawing.Point(207, 52);
            this.maKhoTE.MenuManager = this.barManager1;
            this.maKhoTE.Name = "maKhoTE";
            this.maKhoTE.Size = new System.Drawing.Size(229, 28);
            this.maKhoTE.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.khoGridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 63);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1472, 528);
            this.panelControl2.TabIndex = 6;
            // 
            // khoGridControl
            // 
            this.khoGridControl.DataSource = this.khoBDS;
            this.khoGridControl.Location = new System.Drawing.Point(0, 7);
            this.khoGridControl.MainView = this.gridView1;
            this.khoGridControl.MenuManager = this.barManager1;
            this.khoGridControl.Name = "khoGridControl";
            this.khoGridControl.Size = new System.Drawing.Size(1467, 515);
            this.khoGridControl.TabIndex = 0;
            this.khoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.khoGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // datHangBDS
            // 
            this.datHangBDS.DataMember = "FK_DatHang_Kho";
            this.datHangBDS.DataSource = this.khoBDS;
            // 
            // phieuNhapBDS
            // 
            this.phieuNhapBDS.DataMember = "FK_PhieuNhap_Kho";
            this.phieuNhapBDS.DataSource = this.khoBDS;
            // 
            // phieuXuatBDS
            // 
            this.phieuXuatBDS.DataMember = "FK_PhieuXuat_Kho";
            this.phieuXuatBDS.DataSource = this.khoBDS;
            // 
            // chiNhanhBDS
            // 
            this.chiNhanhBDS.DataMember = "ChiNhanh";
            this.chiNhanhBDS.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // chiNhanhTableAdapter
            // 
            this.chiNhanhTableAdapter.ClearBeforeFill = true;
            // 
            // KhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1472, 811);
            this.Controls.Add(this.comboBoxBranch);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KhoForm";
            this.Text = "Kho";
            this.Load += new System.EventHandler(this.KhoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKhoTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKhoTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem addBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.BarButtonItem updateBtn;
        private DevExpress.XtraBars.BarButtonItem saveBtn;
        private DevExpress.XtraBars.BarButtonItem cancelBtn;
        private DevExpress.XtraBars.BarButtonItem undoBtn;
        private DevExpress.XtraBars.BarButtonItem redoBtn;
        private DevExpress.XtraBars.BarButtonItem refreshBtn;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.BindingSource khoBDS;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource datHangBDS;
        private QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource phieuNhapBDS;
        private QLVT_DATHANGDataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private System.Windows.Forms.BindingSource phieuXuatBDS;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit diaChiTE;
        private DevExpress.XtraEditors.TextEdit tenKhoTE;
        private DevExpress.XtraEditors.TextEdit maKhoTE;
        private System.Windows.Forms.BindingSource chiNhanhBDS;
        private QLVT_DATHANGDataSetTableAdapters.ChiNhanhTableAdapter chiNhanhTableAdapter;
        private DevExpress.XtraGrid.GridControl khoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}