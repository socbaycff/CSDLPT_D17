namespace QLVT_DATHANGD17
{
    partial class AccountForm
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.insertBtn = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addNewAccountBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userRadio = new System.Windows.Forms.RadioButton();
            this.maNVCB = new System.Windows.Forms.ComboBox();
            this.sP_NV_CHUA_TAO_ACCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVT_DATHANGDataSet = new QLVT_DATHANGD17.QLVT_DATHANGDataSet();
            this.loginNameTE = new DevExpress.XtraEditors.TextEdit();
            this.chiNhanhRadio = new System.Windows.Forms.RadioButton();
            this.passwordTE = new DevExpress.XtraEditors.TextEdit();
            this.congTyRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.sP_DANH_SACH_ACCDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sP_DANH_SACH_ACCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DANH_SACH_ACCTableAdapter = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.SP_DANH_SACH_ACCTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.sP_NV_CHUA_TAO_ACCTableAdapter = new QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.SP_NV_CHUA_TAO_ACCTableAdapter();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_NV_CHUA_TAO_ACCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginNameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANH_SACH_ACCDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANH_SACH_ACCBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.deleteBtn,
            this.insertBtn,
            this.refreshBtn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.refreshBtn)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Delete Login";
            this.deleteBtn.Id = 0;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
            // 
            // insertBtn
            // 
            this.insertBtn.Caption = "Insert Login";
            this.insertBtn.Id = 1;
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.insertBtn_ItemClick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Caption = "Refresh";
            this.refreshBtn.Id = 2;
            this.refreshBtn.Name = "refreshBtn";
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(997, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 671);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(997, 19);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 643);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(997, 28);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 643);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 306);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(997, 365);
            this.panelControl1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.addNewAccountBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.userRadio);
            this.groupBox1.Controls.Add(this.maNVCB);
            this.groupBox1.Controls.Add(this.loginNameTE);
            this.groupBox1.Controls.Add(this.chiNhanhRadio);
            this.groupBox1.Controls.Add(this.passwordTE);
            this.groupBox1.Controls.Add(this.congTyRadio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(77, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 245);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add login Form";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(353, 165);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(83, 36);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addNewAccountBtn
            // 
            this.addNewAccountBtn.Location = new System.Drawing.Point(484, 165);
            this.addNewAccountBtn.Name = "addNewAccountBtn";
            this.addNewAccountBtn.Size = new System.Drawing.Size(89, 36);
            this.addNewAccountBtn.TabIndex = 1;
            this.addNewAccountBtn.Text = "Add login";
            this.addNewAccountBtn.UseVisualStyleBackColor = true;
            this.addNewAccountBtn.Click += new System.EventHandler(this.addNewAccountBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã NV";
            // 
            // userRadio
            // 
            this.userRadio.AutoSize = true;
            this.userRadio.Location = new System.Drawing.Point(402, 85);
            this.userRadio.Name = "userRadio";
            this.userRadio.Size = new System.Drawing.Size(56, 21);
            this.userRadio.TabIndex = 9;
            this.userRadio.TabStop = true;
            this.userRadio.Text = "User";
            this.userRadio.UseVisualStyleBackColor = true;
            // 
            // maNVCB
            // 
            this.maNVCB.DataSource = this.sP_NV_CHUA_TAO_ACCBindingSource;
            this.maNVCB.DisplayMember = "MANV";
            this.maNVCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maNVCB.FormattingEnabled = true;
            this.maNVCB.Location = new System.Drawing.Point(232, 36);
            this.maNVCB.Name = "maNVCB";
            this.maNVCB.Size = new System.Drawing.Size(173, 24);
            this.maNVCB.TabIndex = 0;
            this.maNVCB.ValueMember = "MANV";
            // 
            // sP_NV_CHUA_TAO_ACCBindingSource
            // 
            this.sP_NV_CHUA_TAO_ACCBindingSource.DataMember = "SP_NV_CHUA_TAO_ACC";
            this.sP_NV_CHUA_TAO_ACCBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginNameTE
            // 
            this.loginNameTE.Location = new System.Drawing.Point(145, 127);
            this.loginNameTE.MenuManager = this.barManager1;
            this.loginNameTE.Name = "loginNameTE";
            this.loginNameTE.Size = new System.Drawing.Size(125, 22);
            this.loginNameTE.TabIndex = 3;
            // 
            // chiNhanhRadio
            // 
            this.chiNhanhRadio.AutoSize = true;
            this.chiNhanhRadio.Location = new System.Drawing.Point(256, 85);
            this.chiNhanhRadio.Name = "chiNhanhRadio";
            this.chiNhanhRadio.Size = new System.Drawing.Size(91, 21);
            this.chiNhanhRadio.TabIndex = 8;
            this.chiNhanhRadio.TabStop = true;
            this.chiNhanhRadio.Text = "Chi nhánh";
            this.chiNhanhRadio.UseVisualStyleBackColor = true;
            // 
            // passwordTE
            // 
            this.passwordTE.Location = new System.Drawing.Point(145, 181);
            this.passwordTE.MenuManager = this.barManager1;
            this.passwordTE.Name = "passwordTE";
            this.passwordTE.Size = new System.Drawing.Size(125, 22);
            this.passwordTE.TabIndex = 4;
            // 
            // congTyRadio
            // 
            this.congTyRadio.AutoSize = true;
            this.congTyRadio.Location = new System.Drawing.Point(130, 85);
            this.congTyRadio.Name = "congTyRadio";
            this.congTyRadio.Size = new System.Drawing.Size(82, 21);
            this.congTyRadio.TabIndex = 7;
            this.congTyRadio.TabStop = true;
            this.congTyRadio.Text = "Công Ty";
            this.congTyRadio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.sP_DANH_SACH_ACCDataGridView);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 28);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(997, 278);
            this.panelControl2.TabIndex = 5;
            // 
            // sP_DANH_SACH_ACCDataGridView
            // 
            this.sP_DANH_SACH_ACCDataGridView.AllowUserToAddRows = false;
            this.sP_DANH_SACH_ACCDataGridView.AllowUserToDeleteRows = false;
            this.sP_DANH_SACH_ACCDataGridView.AutoGenerateColumns = false;
            this.sP_DANH_SACH_ACCDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sP_DANH_SACH_ACCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sP_DANH_SACH_ACCDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.sP_DANH_SACH_ACCDataGridView.DataSource = this.sP_DANH_SACH_ACCBindingSource;
            this.sP_DANH_SACH_ACCDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_DANH_SACH_ACCDataGridView.Location = new System.Drawing.Point(2, 2);
            this.sP_DANH_SACH_ACCDataGridView.Name = "sP_DANH_SACH_ACCDataGridView";
            this.sP_DANH_SACH_ACCDataGridView.ReadOnly = true;
            this.sP_DANH_SACH_ACCDataGridView.RowTemplate.Height = 24;
            this.sP_DANH_SACH_ACCDataGridView.Size = new System.Drawing.Size(993, 274);
            this.sP_DANH_SACH_ACCDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã NV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LOGINNAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "LOGIN NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HOTEN";
            this.dataGridViewTextBoxColumn3.HeaderText = "Họ Tên";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // sP_DANH_SACH_ACCBindingSource
            // 
            this.sP_DANH_SACH_ACCBindingSource.DataMember = "SP_DANH_SACH_ACC";
            this.sP_DANH_SACH_ACCBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // sP_DANH_SACH_ACCTableAdapter
            // 
            this.sP_DANH_SACH_ACCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // sP_NV_CHUA_TAO_ACCTableAdapter
            // 
            this.sP_NV_CHUA_TAO_ACCTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(498, 0);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(232, 24);
            this.comboBoxBranch.TabIndex = 10;
            this.comboBoxBranch.SelectedIndexChanged += new System.EventHandler(this.comboBoxBranch_SelectedIndexChanged);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 690);
            this.Controls.Add(this.comboBoxBranch);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_NV_CHUA_TAO_ACCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginNameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANH_SACH_ACCDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANH_SACH_ACCBindingSource)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.BarButtonItem insertBtn;
        private DevExpress.XtraBars.BarButtonItem refreshBtn;
        private System.Windows.Forms.BindingSource sP_DANH_SACH_ACCBindingSource;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private QLVT_DATHANGDataSetTableAdapters.SP_DANH_SACH_ACCTableAdapter sP_DANH_SACH_ACCTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sP_DANH_SACH_ACCDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource sP_NV_CHUA_TAO_ACCBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.SP_NV_CHUA_TAO_ACCTableAdapter sP_NV_CHUA_TAO_ACCTableAdapter;
        private System.Windows.Forms.Button addNewAccountBtn;
        private System.Windows.Forms.ComboBox maNVCB;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit loginNameTE;
        private DevExpress.XtraEditors.TextEdit passwordTE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton congTyRadio;
        private System.Windows.Forms.RadioButton userRadio;
        private System.Windows.Forms.RadioButton chiNhanhRadio;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelBtn;
    }
}