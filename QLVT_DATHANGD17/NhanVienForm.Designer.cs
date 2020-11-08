namespace QLVT_DATHANGD17
{
    partial class NhanVienForm
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
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label lUONGLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mANVLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.updateBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.undoBtn = new DevExpress.XtraBars.BarButtonItem();
            this.redoBtn = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.cancelBtn = new DevExpress.XtraBars.BarButtonItem();
            this.saveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.exchangeBtn = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.nameLoginLB = new DevExpress.XtraBars.BarStaticItem();
            this.roleLB = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVT_DATHANG_DSPM = new QLVT_DATHANGD17.QLVT_DATHANG_DSPM();
            this.qLVT_DATHANGDataSet = new QLVT_DATHANGD17.QLVT_DATHANGDataSet();
            this.nhanVienBDS = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.nhanVienDataGridView = new System.Windows.Forms.DataGridView();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mACNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiXoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datHangBDS = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter();
            this.phieuNhapBDS = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter();
            this.phieuXuatBDS = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.PhieuXuatTableAdapter();
            this.v_DS_PHANMANHTableAdapter = new QLVT_DATHANGD17.QLVT_DATHANG_DSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager1 = new QLVT_DATHANGD17.QLVT_DATHANG_DSPMTableAdapters.TableAdapterManager();
            this.chiNhanhBDS = new System.Windows.Forms.BindingSource(this.components);
            this.chiNhanhTableAdapter = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.ChiNhanhTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.exchangeGroup = new System.Windows.Forms.GroupBox();
            this.huyChuyenBtn = new System.Windows.Forms.Button();
            this.chuyenBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chiNhanhChuyenCb = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.detailGroup = new System.Windows.Forms.GroupBox();
            this.maCNTE = new DevExpress.XtraEditors.TextEdit();
            this.maNVSpin = new DevExpress.XtraEditors.SpinEdit();
            this.tenTE = new DevExpress.XtraEditors.TextEdit();
            this.hoTE = new DevExpress.XtraEditors.TextEdit();
            this.trangThaiXoaSpin = new DevExpress.XtraEditors.SpinEdit();
            this.diaChiTE = new DevExpress.XtraEditors.TextEdit();
            this.luongSpin = new DevExpress.XtraEditors.SpinEdit();
            this.ngaySinhDE = new DevExpress.XtraEditors.DateEdit();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            lUONGLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANG_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.exchangeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.detailGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maCNTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNVSpin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trangThaiXoaSpin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongSpin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhDE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhDE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(224, 50);
            nGAYSINHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(79, 19);
            nGAYSINHLabel.TabIndex = 38;
            nGAYSINHLabel.Text = "Ngày sinh";
            // 
            // lUONGLabel
            // 
            lUONGLabel.AutoSize = true;
            lUONGLabel.Location = new System.Drawing.Point(430, 140);
            lUONGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lUONGLabel.Name = "lUONGLabel";
            lUONGLabel.Size = new System.Drawing.Size(54, 19);
            lUONGLabel.TabIndex = 39;
            lUONGLabel.Text = "Lương";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(430, 50);
            dIACHILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(57, 19);
            dIACHILabel.TabIndex = 40;
            dIACHILabel.Text = "Địa chỉ";
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Location = new System.Drawing.Point(627, 140);
            trangThaiXoaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(112, 19);
            trangThaiXoaLabel.TabIndex = 41;
            trangThaiXoaLabel.Text = "Trạng thái xóa";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(45, 140);
            hOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(61, 19);
            hOLabel.TabIndex = 42;
            hOLabel.Text = "Họ Tên";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(45, 50);
            mANVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(59, 19);
            mANVLabel.TabIndex = 44;
            mANVLabel.Text = "MANV:";
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
            this.updateBtn,
            this.deleteBtn,
            this.undoBtn,
            this.saveBtn,
            this.refreshBtn,
            this.exchangeBtn,
            this.cancelBtn,
            this.redoBtn,
            this.nameLoginLB,
            this.roleLB});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 13;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.updateBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.undoBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.redoBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.refreshBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.cancelBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.saveBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.exchangeBtn)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // addBtn
            // 
            this.addBtn.Caption = "Thêm NV";
            this.addBtn.Id = 0;
            this.addBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.add_user;
            this.addBtn.Name = "addBtn";
            this.addBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.addBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBtn_ItemClick);
            // 
            // updateBtn
            // 
            this.updateBtn.Caption = "Sửa NV";
            this.updateBtn.Id = 1;
            this.updateBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.user;
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.updateBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.updateBtn_ItemClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Xóa NV";
            this.deleteBtn.Id = 2;
            this.deleteBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.delete_user;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
            // 
            // undoBtn
            // 
            this.undoBtn.Caption = "Undo";
            this.undoBtn.Enabled = false;
            this.undoBtn.Id = 3;
            this.undoBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.undo;
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.undoBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.undoBtn_ItemClick);
            // 
            // redoBtn
            // 
            this.redoBtn.Caption = "Redo";
            this.redoBtn.Enabled = false;
            this.redoBtn.Id = 10;
            this.redoBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.download;
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.redoBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.redoBtn_ItemClick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Caption = "Refresh";
            this.refreshBtn.Id = 5;
            this.refreshBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.reload;
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.refreshBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBtn_ItemClick);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Caption = "Hủy";
            this.cancelBtn.Enabled = false;
            this.cancelBtn.Id = 9;
            this.cancelBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.remove;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.cancelBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cancelBtn_ItemClick);
            // 
            // saveBtn
            // 
            this.saveBtn.Caption = "Lưu";
            this.saveBtn.Id = 4;
            this.saveBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.floppy_disk;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.saveBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveBtn_ItemClick);
            // 
            // exchangeBtn
            // 
            this.exchangeBtn.Caption = "Chuyển chi nhánh";
            this.exchangeBtn.Id = 6;
            this.exchangeBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.exchange;
            this.exchangeBtn.Name = "exchangeBtn";
            this.exchangeBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.exchangeBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exchangeBtn_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.nameLoginLB),
            new DevExpress.XtraBars.LinkPersistInfo(this.roleLB)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // nameLoginLB
            // 
            this.nameLoginLB.Caption = "barStaticItem1";
            this.nameLoginLB.Id = 11;
            this.nameLoginLB.Name = "nameLoginLB";
            // 
            // roleLB
            // 
            this.roleLB.Caption = "barStaticItem2";
            this.roleLB.Id = 12;
            this.roleLB.Name = "roleLB";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(2408, 63);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 908);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(2408, 29);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 63);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 845);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2408, 63);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 845);
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(1294, 17);
            this.comboBoxBranch.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(448, 27);
            this.comboBoxBranch.TabIndex = 0;
            this.comboBoxBranch.SelectedIndexChanged += new System.EventHandler(this.comboBoxBranch_SelectedIndexChanged);
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.qLVT_DATHANG_DSPM;
            // 
            // qLVT_DATHANG_DSPM
            // 
            this.qLVT_DATHANG_DSPM.DataSetName = "QLVT_DATHANG_DSPM";
            this.qLVT_DATHANG_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBDS
            // 
            this.nhanVienBDS.DataMember = "NhanVien";
            this.nhanVienBDS.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // nhanVienDataGridView
            // 
            this.nhanVienDataGridView.AllowUserToAddRows = false;
            this.nhanVienDataGridView.AllowUserToDeleteRows = false;
            this.nhanVienDataGridView.AutoGenerateColumns = false;
            this.nhanVienDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nhanVienDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.nhanVienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhanVienDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANVDataGridViewTextBoxColumn,
            this.hODataGridViewTextBoxColumn,
            this.tENDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.nGAYSINHDataGridViewTextBoxColumn,
            this.lUONGDataGridViewTextBoxColumn,
            this.mACNDataGridViewTextBoxColumn,
            this.trangThaiXoaDataGridViewTextBoxColumn});
            this.nhanVienDataGridView.DataSource = this.nhanVienBDS;
            this.nhanVienDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.nhanVienDataGridView.Location = new System.Drawing.Point(0, 63);
            this.nhanVienDataGridView.Name = "nhanVienDataGridView";
            this.nhanVienDataGridView.ReadOnly = true;
            this.nhanVienDataGridView.RowTemplate.Height = 28;
            this.nhanVienDataGridView.Size = new System.Drawing.Size(2408, 207);
            this.nhanVienDataGridView.TabIndex = 6;
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "MANV";
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            this.mANVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hODataGridViewTextBoxColumn
            // 
            this.hODataGridViewTextBoxColumn.DataPropertyName = "HO";
            this.hODataGridViewTextBoxColumn.HeaderText = "HO";
            this.hODataGridViewTextBoxColumn.Name = "hODataGridViewTextBoxColumn";
            this.hODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tENDataGridViewTextBoxColumn
            // 
            this.tENDataGridViewTextBoxColumn.DataPropertyName = "TEN";
            this.tENDataGridViewTextBoxColumn.HeaderText = "TEN";
            this.tENDataGridViewTextBoxColumn.Name = "tENDataGridViewTextBoxColumn";
            this.tENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            this.dIACHIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGAYSINHDataGridViewTextBoxColumn
            // 
            this.nGAYSINHDataGridViewTextBoxColumn.DataPropertyName = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.HeaderText = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.Name = "nGAYSINHDataGridViewTextBoxColumn";
            this.nGAYSINHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lUONGDataGridViewTextBoxColumn
            // 
            this.lUONGDataGridViewTextBoxColumn.DataPropertyName = "LUONG";
            this.lUONGDataGridViewTextBoxColumn.HeaderText = "LUONG";
            this.lUONGDataGridViewTextBoxColumn.Name = "lUONGDataGridViewTextBoxColumn";
            this.lUONGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mACNDataGridViewTextBoxColumn
            // 
            this.mACNDataGridViewTextBoxColumn.DataPropertyName = "MACN";
            this.mACNDataGridViewTextBoxColumn.HeaderText = "MACN";
            this.mACNDataGridViewTextBoxColumn.Name = "mACNDataGridViewTextBoxColumn";
            this.mACNDataGridViewTextBoxColumn.ReadOnly = true;
            this.mACNDataGridViewTextBoxColumn.Visible = false;
            // 
            // trangThaiXoaDataGridViewTextBoxColumn
            // 
            this.trangThaiXoaDataGridViewTextBoxColumn.DataPropertyName = "TrangThaiXoa";
            this.trangThaiXoaDataGridViewTextBoxColumn.HeaderText = "TrangThaiXoa";
            this.trangThaiXoaDataGridViewTextBoxColumn.Name = "trangThaiXoaDataGridViewTextBoxColumn";
            this.trangThaiXoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datHangBDS
            // 
            this.datHangBDS.DataMember = "FK_DatHang_NhanVien";
            this.datHangBDS.DataSource = this.nhanVienBDS;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapBDS
            // 
            this.phieuNhapBDS.DataMember = "FK_PhieuNhap_NhanVien";
            this.phieuNhapBDS.DataSource = this.nhanVienBDS;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // phieuXuatBDS
            // 
            this.phieuXuatBDS.DataMember = "FK_PX_NhanVien";
            this.phieuXuatBDS.DataSource = this.nhanVienBDS;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QLVT_DATHANGD17.QLVT_DATHANG_DSPMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.exchangeGroup);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(1742, 270);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(666, 638);
            this.panelControl1.TabIndex = 12;
            // 
            // exchangeGroup
            // 
            this.exchangeGroup.Controls.Add(this.huyChuyenBtn);
            this.exchangeGroup.Controls.Add(this.chuyenBtn);
            this.exchangeGroup.Controls.Add(this.label1);
            this.exchangeGroup.Controls.Add(this.chiNhanhChuyenCb);
            this.exchangeGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exchangeGroup.Location = new System.Drawing.Point(2, 2);
            this.exchangeGroup.Margin = new System.Windows.Forms.Padding(4);
            this.exchangeGroup.Name = "exchangeGroup";
            this.exchangeGroup.Padding = new System.Windows.Forms.Padding(4);
            this.exchangeGroup.Size = new System.Drawing.Size(662, 634);
            this.exchangeGroup.TabIndex = 0;
            this.exchangeGroup.TabStop = false;
            this.exchangeGroup.Text = "Chuyển CN";
            // 
            // huyChuyenBtn
            // 
            this.huyChuyenBtn.Location = new System.Drawing.Point(302, 135);
            this.huyChuyenBtn.Name = "huyChuyenBtn";
            this.huyChuyenBtn.Size = new System.Drawing.Size(85, 32);
            this.huyChuyenBtn.TabIndex = 3;
            this.huyChuyenBtn.Text = "Hủy";
            this.huyChuyenBtn.UseVisualStyleBackColor = true;
            this.huyChuyenBtn.Click += new System.EventHandler(this.huyChuyenBtn_Click);
            // 
            // chuyenBtn
            // 
            this.chuyenBtn.Location = new System.Drawing.Point(167, 135);
            this.chuyenBtn.Name = "chuyenBtn";
            this.chuyenBtn.Size = new System.Drawing.Size(81, 32);
            this.chuyenBtn.TabIndex = 2;
            this.chuyenBtn.Text = "Chuyển";
            this.chuyenBtn.UseVisualStyleBackColor = true;
            this.chuyenBtn.Click += new System.EventHandler(this.chuyenBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi nhánh đích";
            // 
            // chiNhanhChuyenCb
            // 
            this.chiNhanhChuyenCb.DataSource = this.v_DS_PHANMANHBindingSource1;
            this.chiNhanhChuyenCb.DisplayMember = "TENCN";
            this.chiNhanhChuyenCb.FormattingEnabled = true;
            this.chiNhanhChuyenCb.Location = new System.Drawing.Point(141, 61);
            this.chiNhanhChuyenCb.Name = "chiNhanhChuyenCb";
            this.chiNhanhChuyenCb.Size = new System.Drawing.Size(300, 27);
            this.chiNhanhChuyenCb.TabIndex = 0;
            this.chiNhanhChuyenCb.ValueMember = "TENSERVER";
            // 
            // v_DS_PHANMANHBindingSource1
            // 
            this.v_DS_PHANMANHBindingSource1.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource1.DataSource = this.qLVT_DATHANG_DSPM;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.detailGroup);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 270);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1742, 638);
            this.panelControl2.TabIndex = 13;
            // 
            // detailGroup
            // 
            this.detailGroup.Controls.Add(this.maCNTE);
            this.detailGroup.Controls.Add(mANVLabel);
            this.detailGroup.Controls.Add(this.maNVSpin);
            this.detailGroup.Controls.Add(this.tenTE);
            this.detailGroup.Controls.Add(hOLabel);
            this.detailGroup.Controls.Add(this.hoTE);
            this.detailGroup.Controls.Add(trangThaiXoaLabel);
            this.detailGroup.Controls.Add(this.trangThaiXoaSpin);
            this.detailGroup.Controls.Add(dIACHILabel);
            this.detailGroup.Controls.Add(this.diaChiTE);
            this.detailGroup.Controls.Add(lUONGLabel);
            this.detailGroup.Controls.Add(this.luongSpin);
            this.detailGroup.Controls.Add(nGAYSINHLabel);
            this.detailGroup.Controls.Add(this.ngaySinhDE);
            this.detailGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailGroup.Location = new System.Drawing.Point(2, 2);
            this.detailGroup.Margin = new System.Windows.Forms.Padding(4);
            this.detailGroup.Name = "detailGroup";
            this.detailGroup.Padding = new System.Windows.Forms.Padding(4);
            this.detailGroup.Size = new System.Drawing.Size(1738, 634);
            this.detailGroup.TabIndex = 0;
            this.detailGroup.TabStop = false;
            this.detailGroup.Text = "Thông tin";
            // 
            // maCNTE
            // 
            this.maCNTE.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBDS, "MACN", true));
            this.maCNTE.Location = new System.Drawing.Point(632, 82);
            this.maCNTE.Margin = new System.Windows.Forms.Padding(4);
            this.maCNTE.MenuManager = this.barManager1;
            this.maCNTE.Name = "maCNTE";
            this.maCNTE.Size = new System.Drawing.Size(150, 28);
            this.maCNTE.TabIndex = 46;
            this.maCNTE.Visible = false;
            // 
            // maNVSpin
            // 
            this.maNVSpin.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBDS, "MANV", true));
            this.maNVSpin.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.maNVSpin.Location = new System.Drawing.Point(50, 83);
            this.maNVSpin.Margin = new System.Windows.Forms.Padding(4);
            this.maNVSpin.MenuManager = this.barManager1;
            this.maNVSpin.Name = "maNVSpin";
            this.maNVSpin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.maNVSpin.Properties.IsFloatValue = false;
            this.maNVSpin.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.maNVSpin.Properties.Mask.EditMask = "n0";
            this.maNVSpin.Size = new System.Drawing.Size(150, 28);
            this.maNVSpin.TabIndex = 45;
            // 
            // tenTE
            // 
            this.tenTE.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBDS, "TEN", true));
            this.tenTE.Location = new System.Drawing.Point(208, 172);
            this.tenTE.Margin = new System.Windows.Forms.Padding(4);
            this.tenTE.MenuManager = this.barManager1;
            this.tenTE.Name = "tenTE";
            this.tenTE.Size = new System.Drawing.Size(150, 28);
            this.tenTE.TabIndex = 44;
            // 
            // hoTE
            // 
            this.hoTE.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBDS, "HO", true));
            this.hoTE.Location = new System.Drawing.Point(50, 172);
            this.hoTE.Margin = new System.Windows.Forms.Padding(4);
            this.hoTE.MenuManager = this.barManager1;
            this.hoTE.Name = "hoTE";
            this.hoTE.Size = new System.Drawing.Size(150, 28);
            this.hoTE.TabIndex = 43;
            // 
            // trangThaiXoaSpin
            // 
            this.trangThaiXoaSpin.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBDS, "TrangThaiXoa", true));
            this.trangThaiXoaSpin.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.trangThaiXoaSpin.Enabled = false;
            this.trangThaiXoaSpin.Location = new System.Drawing.Point(632, 172);
            this.trangThaiXoaSpin.Margin = new System.Windows.Forms.Padding(4);
            this.trangThaiXoaSpin.MenuManager = this.barManager1;
            this.trangThaiXoaSpin.Name = "trangThaiXoaSpin";
            this.trangThaiXoaSpin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.trangThaiXoaSpin.Properties.IsFloatValue = false;
            this.trangThaiXoaSpin.Properties.Mask.EditMask = "n0";
            this.trangThaiXoaSpin.Size = new System.Drawing.Size(150, 28);
            this.trangThaiXoaSpin.TabIndex = 42;
            // 
            // diaChiTE
            // 
            this.diaChiTE.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBDS, "DIACHI", true));
            this.diaChiTE.Location = new System.Drawing.Point(435, 83);
            this.diaChiTE.Margin = new System.Windows.Forms.Padding(4);
            this.diaChiTE.MenuManager = this.barManager1;
            this.diaChiTE.Name = "diaChiTE";
            this.diaChiTE.Size = new System.Drawing.Size(150, 28);
            this.diaChiTE.TabIndex = 41;
            // 
            // luongSpin
            // 
            this.luongSpin.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBDS, "LUONG", true));
            this.luongSpin.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.luongSpin.Location = new System.Drawing.Point(435, 174);
            this.luongSpin.Margin = new System.Windows.Forms.Padding(4);
            this.luongSpin.MenuManager = this.barManager1;
            this.luongSpin.Name = "luongSpin";
            this.luongSpin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luongSpin.Properties.Mask.EditMask = "n0";
            this.luongSpin.Size = new System.Drawing.Size(150, 28);
            this.luongSpin.TabIndex = 40;
            // 
            // ngaySinhDE
            // 
            this.ngaySinhDE.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBDS, "NGAYSINH", true));
            this.ngaySinhDE.EditValue = null;
            this.ngaySinhDE.Location = new System.Drawing.Point(208, 82);
            this.ngaySinhDE.Margin = new System.Windows.Forms.Padding(4);
            this.ngaySinhDE.MenuManager = this.barManager1;
            this.ngaySinhDE.Name = "ngaySinhDE";
            this.ngaySinhDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaySinhDE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaySinhDE.Size = new System.Drawing.Size(150, 28);
            this.ngaySinhDE.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã NV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 137;
            // 
            // NhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1944, 963);
            this.Controls.Add(this.comboBoxBranch);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.nhanVienDataGridView);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhanVienForm";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANG_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.exchangeGroup.ResumeLayout(false);
            this.exchangeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.detailGroup.ResumeLayout(false);
            this.detailGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maCNTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNVSpin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trangThaiXoaSpin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongSpin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhDE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhDE.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource nhanVienBDS;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private QLVT_DATHANGDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nhanVienDataGridView;
        private System.Windows.Forms.BindingSource datHangBDS;
        private QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource phieuNhapBDS;
        private QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource phieuXuatBDS;
        private QLVT_DATHANGDataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private QLVT_DATHANG_DSPM qLVT_DATHANG_DSPM;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private QLVT_DATHANG_DSPMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLVT_DATHANG_DSPMTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.BindingSource chiNhanhBDS;
        private QLVT_DATHANGDataSetTableAdapters.ChiNhanhTableAdapter chiNhanhTableAdapter;
        private DevExpress.XtraBars.BarButtonItem updateBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.BarButtonItem undoBtn;
        private DevExpress.XtraBars.BarButtonItem saveBtn;
        private DevExpress.XtraBars.BarButtonItem refreshBtn;
        private DevExpress.XtraBars.BarButtonItem exchangeBtn;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.GroupBox detailGroup;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox exchangeGroup;
        private DevExpress.XtraEditors.DateEdit ngaySinhDE;
        private DevExpress.XtraEditors.SpinEdit maNVSpin;
        private DevExpress.XtraEditors.TextEdit tenTE;
        private DevExpress.XtraEditors.TextEdit hoTE;
        private DevExpress.XtraEditors.SpinEdit trangThaiXoaSpin;
        private DevExpress.XtraEditors.TextEdit diaChiTE;
        private DevExpress.XtraEditors.SpinEdit luongSpin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiXoaDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.TextEdit maCNTE;
        private System.Windows.Forms.Button huyChuyenBtn;
        private System.Windows.Forms.Button chuyenBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chiNhanhChuyenCb;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource1;
        private DevExpress.XtraBars.BarButtonItem cancelBtn;
        private DevExpress.XtraBars.BarButtonItem redoBtn;
        private DevExpress.XtraBars.BarStaticItem nameLoginLB;
        private DevExpress.XtraBars.BarStaticItem roleLB;
    }
}