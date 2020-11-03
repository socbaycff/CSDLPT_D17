namespace QLVT_DATHANGD17
{
    partial class VatTuForm
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label sOLUONGTONLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.updateBtn = new DevExpress.XtraBars.BarButtonItem();
            this.saveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.cancelBtn = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.undoBtn = new DevExpress.XtraBars.BarButtonItem();
            this.redoBtn = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.qLVT_DATHANGDataSet = new QLVT_DATHANGD17.QLVT_DATHANGDataSet();
            this.vatTuBDS = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter();
            this.cTPNTableAdapter = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.CTPNTableAdapter();
            this.cTPXTableAdapter = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.CTPXTableAdapter();
            this.vattuDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SLTTE = new DevExpress.XtraEditors.SpinEdit();
            this.DVTTE = new DevExpress.XtraEditors.TextEdit();
            this.tenVTTE = new DevExpress.XtraEditors.TextEdit();
            this.maVTTE = new DevExpress.XtraEditors.TextEdit();
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTPNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTPXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            sOLUONGTONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatTuBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SLTTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVTTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenVTTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maVTTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Font = new System.Drawing.Font("Tahoma", 8F);
            mAVTLabel.Location = new System.Drawing.Point(185, 33);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(54, 19);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã VT";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Font = new System.Drawing.Font("Tahoma", 8F);
            tENVTLabel.Location = new System.Drawing.Point(185, 127);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(61, 19);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "Tên VT";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Font = new System.Drawing.Font("Tahoma", 8F);
            dVTLabel.Location = new System.Drawing.Point(716, 38);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(83, 19);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "Đơn vị tồn";
            // 
            // sOLUONGTONLabel
            // 
            sOLUONGTONLabel.AutoSize = true;
            sOLUONGTONLabel.Font = new System.Drawing.Font("Tahoma", 8F);
            sOLUONGTONLabel.Location = new System.Drawing.Point(716, 132);
            sOLUONGTONLabel.Name = "sOLUONGTONLabel";
            sOLUONGTONLabel.Size = new System.Drawing.Size(101, 19);
            sOLUONGTONLabel.TabIndex = 6;
            sOLUONGTONLabel.Text = "Số lượng tồn";
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
            this.barButtonItem1,
            this.addBtn,
            this.deleteBtn,
            this.updateBtn,
            this.saveBtn,
            this.cancelBtn,
            this.refreshBtn,
            this.undoBtn,
            this.redoBtn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.refreshBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.undoBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.redoBtn)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // addBtn
            // 
            this.addBtn.Caption = "Thêm VT";
            this.addBtn.Id = 1;
            this.addBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.plus;
            this.addBtn.Name = "addBtn";
            this.addBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.addBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBtn_ItemClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Xóa VT";
            this.deleteBtn.Id = 2;
            this.deleteBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.remove__1_;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
            // 
            // updateBtn
            // 
            this.updateBtn.Caption = "Chỉnh sửa VT";
            this.updateBtn.Id = 3;
            this.updateBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.pencil;
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.updateBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.updateBtn_ItemClick);
            // 
            // saveBtn
            // 
            this.saveBtn.Caption = "Lưu";
            this.saveBtn.Id = 4;
            this.saveBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.floppy_disk__1_;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.saveBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveBtn_ItemClick);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Caption = "Hủy";
            this.cancelBtn.Id = 5;
            this.cancelBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.prohibition;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.cancelBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cancelBtn_ItemClick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Caption = "Refresh";
            this.refreshBtn.Id = 6;
            this.refreshBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.synchronization;
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.refreshBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBtn_ItemClick);
            // 
            // undoBtn
            // 
            this.undoBtn.Caption = "Undo";
            this.undoBtn.Enabled = false;
            this.undoBtn.Id = 7;
            this.undoBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.undo__1_;
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.undoBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.undoBtn_ItemClick);
            // 
            // redoBtn
            // 
            this.redoBtn.Caption = "Redo";
            this.redoBtn.Enabled = false;
            this.redoBtn.Id = 8;
            this.redoBtn.ImageOptions.Image = global::QLVT_DATHANGD17.Properties.Resources.redo__1_;
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.redoBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.redoBtn_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1572, 63);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 887);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1572, 19);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 63);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 824);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1572, 63);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 824);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm VT";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(1152, 18);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(310, 27);
            this.comboBoxBranch.TabIndex = 4;
            this.comboBoxBranch.SelectedIndexChanged += new System.EventHandler(this.comboBoxBranch_SelectedIndexChanged);
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vatTuBDS
            // 
            this.vatTuBDS.DataMember = "Vattu";
            this.vatTuBDS.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = this.cTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = this.cTPXTableAdapter;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // vattuDataGridView
            // 
            this.vattuDataGridView.AllowUserToAddRows = false;
            this.vattuDataGridView.AllowUserToDeleteRows = false;
            this.vattuDataGridView.AutoGenerateColumns = false;
            this.vattuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vattuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vattuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.vattuDataGridView.DataSource = this.vatTuBDS;
            this.vattuDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.vattuDataGridView.Location = new System.Drawing.Point(0, 63);
            this.vattuDataGridView.Name = "vattuDataGridView";
            this.vattuDataGridView.ReadOnly = true;
            this.vattuDataGridView.RowTemplate.Height = 28;
            this.vattuDataGridView.Size = new System.Drawing.Size(1572, 479);
            this.vattuDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAVT";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAVT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENVT";
            this.dataGridViewTextBoxColumn2.HeaderText = "TENVT";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DVT";
            this.dataGridViewTextBoxColumn3.HeaderText = "DVT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SOLUONGTON";
            this.dataGridViewTextBoxColumn4.HeaderText = "SOLUONGTON";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(sOLUONGTONLabel);
            this.groupBox1.Controls.Add(this.SLTTE);
            this.groupBox1.Controls.Add(dVTLabel);
            this.groupBox1.Controls.Add(this.DVTTE);
            this.groupBox1.Controls.Add(tENVTLabel);
            this.groupBox1.Controls.Add(this.tenVTTE);
            this.groupBox1.Controls.Add(mAVTLabel);
            this.groupBox1.Controls.Add(this.maVTTE);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 542);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1572, 345);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // SLTTE
            // 
            this.SLTTE.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vatTuBDS, "SOLUONGTON", true));
            this.SLTTE.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SLTTE.Location = new System.Drawing.Point(857, 128);
            this.SLTTE.MenuManager = this.barManager1;
            this.SLTTE.Name = "SLTTE";
            this.SLTTE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SLTTE.Size = new System.Drawing.Size(286, 28);
            this.SLTTE.TabIndex = 7;
            // 
            // DVTTE
            // 
            this.DVTTE.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vatTuBDS, "DVT", true));
            this.DVTTE.Location = new System.Drawing.Point(857, 34);
            this.DVTTE.MenuManager = this.barManager1;
            this.DVTTE.Name = "DVTTE";
            this.DVTTE.Size = new System.Drawing.Size(286, 28);
            this.DVTTE.TabIndex = 5;
            // 
            // tenVTTE
            // 
            this.tenVTTE.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vatTuBDS, "TENVT", true));
            this.tenVTTE.Location = new System.Drawing.Point(285, 123);
            this.tenVTTE.MenuManager = this.barManager1;
            this.tenVTTE.Name = "tenVTTE";
            this.tenVTTE.Size = new System.Drawing.Size(322, 28);
            this.tenVTTE.TabIndex = 3;
            // 
            // maVTTE
            // 
            this.maVTTE.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vatTuBDS, "MAVT", true));
            this.maVTTE.Location = new System.Drawing.Point(285, 29);
            this.maVTTE.MenuManager = this.barManager1;
            this.maVTTE.Name = "maVTTE";
            this.maVTTE.Size = new System.Drawing.Size(322, 28);
            this.maVTTE.TabIndex = 1;
            // 
            // cTDDHBindingSource
            // 
            this.cTDDHBindingSource.DataMember = "FK_CTDDH_VatTu";
            this.cTDDHBindingSource.DataSource = this.vatTuBDS;
            // 
            // cTPNBindingSource
            // 
            this.cTPNBindingSource.DataMember = "FK_CTPN_VatTu";
            this.cTPNBindingSource.DataSource = this.vatTuBDS;
            // 
            // cTPXBindingSource
            // 
            this.cTPXBindingSource.DataMember = "FK_CTPX_VatTu";
            this.cTPXBindingSource.DataSource = this.vatTuBDS;
            // 
            // VatTuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 906);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vattuDataGridView);
            this.Controls.Add(this.comboBoxBranch);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VatTuForm";
            this.Text = "Vật Tư";
            this.Load += new System.EventHandler(this.VatTuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatTuBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SLTTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVTTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenVTTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maVTTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXBindingSource)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem addBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.BarButtonItem updateBtn;
        private DevExpress.XtraBars.BarButtonItem saveBtn;
        private DevExpress.XtraBars.BarButtonItem cancelBtn;
        private DevExpress.XtraBars.BarButtonItem refreshBtn;
        private DevExpress.XtraBars.BarButtonItem undoBtn;
        private DevExpress.XtraBars.BarButtonItem redoBtn;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.BindingSource vatTuBDS;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vattuDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SpinEdit SLTTE;
        private DevExpress.XtraEditors.TextEdit DVTTE;
        private DevExpress.XtraEditors.TextEdit tenVTTE;
        private DevExpress.XtraEditors.TextEdit maVTTE;
        private QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource cTPNBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private System.Windows.Forms.BindingSource cTPXBindingSource;
    }
}