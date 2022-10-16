namespace dvTechnicalOffice
{
    partial class frmDivAndCat
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
            this.clbDivision = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.clbCat = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.clbDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbCat)).BeginInit();
            this.SuspendLayout();
            // 
            // clbDivision
            // 
            this.clbDivision.Appearance.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbDivision.Appearance.Options.UseFont = true;
            this.clbDivision.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الشعبة الأولى"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الشعبة الثانية"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الشعبة الثالثة"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الشعبة الرابعة"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الشعبة الخامسة"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الشعبة السادسة"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الشعبة السابعة")});
            this.clbDivision.Location = new System.Drawing.Point(15, 40);
            this.clbDivision.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.clbDivision.Name = "clbDivision";
            this.clbDivision.Size = new System.Drawing.Size(208, 313);
            this.clbDivision.TabIndex = 0;
            // 
            // clbCat
            // 
            this.clbCat.Appearance.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbCat.Appearance.Options.UseFont = true;
            this.clbCat.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الفئة الأولى"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الفئة الثانية"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الفئة الثالثة"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الفئة الرابعة"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الفئة الخامسة"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الفئة السادسة"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الفئة السابعة")});
            this.clbCat.Location = new System.Drawing.Point(235, 40);
            this.clbCat.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.clbCat.Name = "clbCat";
            this.clbCat.Size = new System.Drawing.Size(198, 313);
            this.clbCat.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(292, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 32);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "الفئات";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(86, 0);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 32);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "الشعب";
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Location = new System.Drawing.Point(15, 358);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(418, 49);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "بحث";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // frmDivAndCat
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 412);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.clbCat);
            this.Controls.Add(this.clbDivision);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmDivAndCat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الشعب والفئات";
            ((System.ComponentModel.ISupportInitialize)(this.clbDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        public DevExpress.XtraEditors.CheckedListBoxControl clbCat;
        public DevExpress.XtraEditors.CheckedListBoxControl clbDivision;
    }
}