namespace dvTechnicalOffice
{
    partial class frmContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContact));
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtMobile = new DevExpress.XtraEditors.TextEdit();
            this.btnRecord = new DevExpress.XtraEditors.SimpleButton();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtSite = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(462, 281);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txtName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(442, 42);
            this.layoutControlItem1.Text = "الأسم";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(63, 26);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(363, 38);
            this.txtName.StyleController = this.layoutControl1;
            this.txtName.TabIndex = 4;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobile_KeyDown);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtMobile);
            this.layoutControl1.Controls.Add(this.btnRecord);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.txtEmail);
            this.layoutControl1.Controls.Add(this.txtSite);
            this.layoutControl1.Controls.Add(this.txtAddress);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(462, 281);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(12, 54);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtMobile.Properties.Appearance.Options.UseFont = true;
            this.txtMobile.Size = new System.Drawing.Size(363, 38);
            this.txtMobile.StyleController = this.layoutControl1;
            this.txtMobile.TabIndex = 9;
            this.txtMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobile_KeyDown);
            // 
            // btnRecord
            // 
            this.btnRecord.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnRecord.Appearance.Options.UseFont = true;
            this.btnRecord.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRecord.ImageOptions.Image")));
            this.btnRecord.Location = new System.Drawing.Point(12, 222);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(438, 47);
            this.btnRecord.StyleController = this.layoutControl1;
            this.btnRecord.TabIndex = 8;
            this.btnRecord.Text = "تسجيل";
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(363, 38);
            this.txtEmail.StyleController = this.layoutControl1;
            this.txtEmail.TabIndex = 4;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobile_KeyDown);
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(12, 138);
            this.txtSite.Name = "txtSite";
            this.txtSite.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtSite.Properties.Appearance.Options.UseFont = true;
            this.txtSite.Size = new System.Drawing.Size(363, 38);
            this.txtSite.StyleController = this.layoutControl1;
            this.txtSite.TabIndex = 9;
            this.txtSite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobile_KeyDown);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(12, 180);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Size = new System.Drawing.Size(363, 38);
            this.txtAddress.StyleController = this.layoutControl1;
            this.txtAddress.TabIndex = 4;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobile_KeyDown);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnRecord;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 210);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(99, 40);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(442, 51);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.txtMobile;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(442, 42);
            this.layoutControlItem4.Text = "الموبايل";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(63, 26);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txtEmail;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem2.CustomizationFormText = "الأسم";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(442, 42);
            this.layoutControlItem2.Text = "الإيميل";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(63, 26);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.txtSite;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem3.CustomizationFormText = "الموبايل";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 126);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(442, 42);
            this.layoutControlItem3.Text = "السايت";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(63, 26);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.txtAddress;
            this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem6.CustomizationFormText = "الأسم";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(442, 42);
            this.layoutControlItem6.Text = "العنوان";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(63, 26);
            // 
            // frmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 281);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmContact";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "معلومات الإتصال";
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnRecord;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        public DevExpress.XtraEditors.TextEdit txtAddress;
        public DevExpress.XtraEditors.TextEdit txtSite;
        public DevExpress.XtraEditors.TextEdit txtEmail;
        public DevExpress.XtraEditors.TextEdit txtName;
        public DevExpress.XtraEditors.TextEdit txtMobile;
    }
}