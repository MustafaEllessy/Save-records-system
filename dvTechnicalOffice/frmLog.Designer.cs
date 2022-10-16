namespace dvTechnicalOffice
{
    partial class frmLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLog));
            this.btnEnter = new DevExpress.XtraEditors.SimpleButton();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.btnEnter.Appearance.Options.UseFont = true;
            this.btnEnter.Appearance.Options.UseForeColor = true;
            this.btnEnter.Location = new System.Drawing.Point(196, 286);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(344, 47);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "تسجيل الدخول";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(196, 79);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Size = new System.Drawing.Size(398, 38);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(196, 181);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(398, 38);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(31, 82);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(125, 32);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "اسم المستخدم";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(40, 184);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 32);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "كلمة المرور";
            // 
            // frmLog
            // 
            this.Appearance.BackColor = System.Drawing.Color.Lime;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 405);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnEnter);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmLog.IconOptions.LargeImage")));
            this.Name = "frmLog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.Load += new System.EventHandler(this.frmLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnEnter;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}