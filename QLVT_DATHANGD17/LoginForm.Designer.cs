namespace QLVT_DATHANGD17
{
    partial class LoginForm
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
            this.qLVT_DATHANG_DSPM = new QLVT_DATHANGD17.QLVT_DATHANG_DSPM();
            this.BDS_View_DSPM = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new QLVT_DATHANGD17.QLVT_DATHANG_DSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANGD17.QLVT_DATHANG_DSPMTableAdapters.TableAdapterManager();
            this.comboBoxSVName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginNameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANG_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDS_View_DSPM)).BeginInit();
            this.SuspendLayout();
            // 
            // qLVT_DATHANG_DSPM
            // 
            this.qLVT_DATHANG_DSPM.DataSetName = "QLVT_DATHANG_DSPM";
            this.qLVT_DATHANG_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BDS_View_DSPM
            // 
            this.BDS_View_DSPM.DataMember = "V_DS_PHANMANH";
            this.BDS_View_DSPM.DataSource = this.qLVT_DATHANG_DSPM;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANGD17.QLVT_DATHANG_DSPMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboBoxSVName
            // 
            this.comboBoxSVName.DataSource = this.BDS_View_DSPM;
            this.comboBoxSVName.DisplayMember = "TENCN";
            this.comboBoxSVName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSVName.Font = new System.Drawing.Font("Tahoma", 16F);
            this.comboBoxSVName.FormattingEnabled = true;
            this.comboBoxSVName.Location = new System.Drawing.Point(424, 66);
            this.comboBoxSVName.Name = "comboBoxSVName";
            this.comboBoxSVName.Size = new System.Drawing.Size(507, 47);
            this.comboBoxSVName.TabIndex = 1;
            this.comboBoxSVName.ValueMember = "TENSERVER";
            this.comboBoxSVName.SelectedIndexChanged += new System.EventHandler(this.comboBoxSVName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(184, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label2.Location = new System.Drawing.Point(184, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chi Nhánh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label3.Location = new System.Drawing.Point(184, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật Khẩu";
            // 
            // loginNameTB
            // 
            this.loginNameTB.Font = new System.Drawing.Font("Tahoma", 16F);
            this.loginNameTB.Location = new System.Drawing.Point(424, 147);
            this.loginNameTB.Name = "loginNameTB";
            this.loginNameTB.Size = new System.Drawing.Size(507, 46);
            this.loginNameTB.TabIndex = 5;
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Tahoma", 16F);
            this.passwordTB.Location = new System.Drawing.Point(424, 220);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(507, 46);
            this.passwordTB.TabIndex = 6;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Tahoma", 16F);
            this.loginBtn.Location = new System.Drawing.Point(466, 298);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(205, 51);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "Đăng Nhập";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Tahoma", 16F);
            this.exitBtn.Location = new System.Drawing.Point(691, 298);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(205, 51);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 456);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSVName);
            this.Name = "LoginForm";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANG_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDS_View_DSPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLVT_DATHANG_DSPM qLVT_DATHANG_DSPM;
        private System.Windows.Forms.BindingSource BDS_View_DSPM;
        private QLVT_DATHANG_DSPMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLVT_DATHANG_DSPMTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBoxSVName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginNameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}