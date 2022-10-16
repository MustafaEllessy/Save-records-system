namespace dvTechnicalOffice
{
    partial class frmContractDivsInput
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
            this.clbCats = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.btnRecord = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.clbCats)).BeginInit();
            this.SuspendLayout();
            // 
            // clbCats
            // 
            this.clbCats.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbCats.Appearance.Options.UseFont = true;
            this.clbCats.Appearance.Options.UseTextOptions = true;
            this.clbCats.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clbCats.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clbCats.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الفئة الأولى"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الفئة الثانية"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الفئة الثالثة"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الفئة الرابعة"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الفئة الخامسة"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الفئة السادسة"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الفئة السابعة")});
            this.clbCats.Location = new System.Drawing.Point(4, 2);
            this.clbCats.Name = "clbCats";
            this.clbCats.Size = new System.Drawing.Size(491, 262);
            this.clbCats.TabIndex = 0;
            this.clbCats.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clbCats_KeyDown);
            // 
            // btnRecord
            // 
            this.btnRecord.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Appearance.Options.UseFont = true;
            this.btnRecord.Location = new System.Drawing.Point(4, 270);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(491, 55);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.Text = "تسجيل";
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // frmContractDivsInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 328);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.clbCats);
            this.Name = "frmContractDivsInput";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الفئات";
            ((System.ComponentModel.ISupportInitialize)(this.clbCats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnRecord;
        public DevExpress.XtraEditors.CheckedListBoxControl clbCats;
    }
}