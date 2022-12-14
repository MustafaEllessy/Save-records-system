namespace dvTechnicalOffice.UI.Modules
{
    partial class SupplierInput
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.btnAttachFile = new DevExpress.XtraEditors.SimpleButton();
            this.memotxtNotes = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbxNotHandled = new System.Windows.Forms.CheckBox();
            this.cbxHandled = new System.Windows.Forms.CheckBox();
            this.btnContact = new DevExpress.XtraEditors.SimpleButton();
            this.btnAttach = new DevExpress.XtraEditors.SimpleButton();
            this.txtSN = new DevExpress.XtraEditors.TextEdit();
            this.txtCompName = new DevExpress.XtraEditors.TextEdit();
            this.memotxtOldBusiness = new DevExpress.XtraEditors.MemoEdit();
            this.memClassify = new DevExpress.XtraEditors.MemoEdit();
            this.cbxGover = new DevExpress.XtraEditors.ComboBoxEdit();
            this.clbDoc = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtCompanyName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.vpSupplier = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.memotxtNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memotxtOldBusiness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memClassify.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGover.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAttachFile
            // 
            this.btnAttachFile.Appearance.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnAttachFile.Appearance.Options.UseFont = true;
            this.btnAttachFile.Location = new System.Drawing.Point(33, 562);
            this.btnAttachFile.Name = "btnAttachFile";
            this.btnAttachFile.Size = new System.Drawing.Size(741, 42);
            this.btnAttachFile.TabIndex = 8;
            this.btnAttachFile.Text = "إدارج ملف";
            // 
            // memotxtNotes
            // 
            this.memotxtNotes.EditValue = "";
            this.memotxtNotes.Location = new System.Drawing.Point(20, 606);
            this.memotxtNotes.Name = "memotxtNotes";
            this.memotxtNotes.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.memotxtNotes.Properties.Appearance.Options.UseFont = true;
            this.memotxtNotes.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.memotxtNotes.Size = new System.Drawing.Size(536, 50);
            this.memotxtNotes.StyleController = this.layoutControl1;
            this.memotxtNotes.TabIndex = 7;
            this.memotxtNotes.EditValueChanged += new System.EventHandler(this.memotxtNotes_EditValueChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Controls.Add(this.btnContact);
            this.layoutControl1.Controls.Add(this.btnAttach);
            this.layoutControl1.Controls.Add(this.txtSN);
            this.layoutControl1.Controls.Add(this.txtCompName);
            this.layoutControl1.Controls.Add(this.memotxtOldBusiness);
            this.layoutControl1.Controls.Add(this.memotxtNotes);
            this.layoutControl1.Controls.Add(this.memClassify);
            this.layoutControl1.Controls.Add(this.cbxGover);
            this.layoutControl1.Controls.Add(this.clbDoc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(903, 328, 812, 500);
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(843, 676);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbxNotHandled);
            this.panelControl1.Controls.Add(this.cbxHandled);
            this.panelControl1.Location = new System.Drawing.Point(12, 517);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(819, 77);
            this.panelControl1.TabIndex = 16;
            // 
            // cbxNotHandled
            // 
            this.cbxNotHandled.AutoSize = true;
            this.cbxNotHandled.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNotHandled.Location = new System.Drawing.Point(279, 17);
            this.cbxNotHandled.Name = "cbxNotHandled";
            this.cbxNotHandled.Size = new System.Drawing.Size(250, 36);
            this.cbxNotHandled.TabIndex = 1;
            this.cbxNotHandled.Text = "لم يتم التعامل مع الهيئة";
            this.cbxNotHandled.UseVisualStyleBackColor = true;
            // 
            // cbxHandled
            // 
            this.cbxHandled.AutoSize = true;
            this.cbxHandled.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHandled.Location = new System.Drawing.Point(562, 17);
            this.cbxHandled.Name = "cbxHandled";
            this.cbxHandled.Size = new System.Drawing.Size(218, 36);
            this.cbxHandled.TabIndex = 0;
            this.cbxHandled.Text = "تم التعامل مع الهيئة";
            this.cbxHandled.UseVisualStyleBackColor = true;
            // 
            // btnContact
            // 
            this.btnContact.Appearance.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnContact.Appearance.Options.UseFont = true;
            this.btnContact.Location = new System.Drawing.Point(12, 364);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(407, 42);
            this.btnContact.StyleController = this.layoutControl1;
            this.btnContact.TabIndex = 10;
            this.btnContact.Text = "معلومات الإتصال";
            this.btnContact.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.Appearance.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnAttach.Appearance.Options.UseFont = true;
            this.btnAttach.Location = new System.Drawing.Point(423, 364);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(408, 42);
            this.btnAttach.StyleController = this.layoutControl1;
            this.btnAttach.TabIndex = 9;
            this.btnAttach.Text = "ارفاق ملفات";
            this.btnAttach.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(25, 25);
            this.txtSN.Name = "txtSN";
            this.txtSN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtSN.Properties.Appearance.Options.UseFont = true;
            this.txtSN.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSN.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtSN.Properties.ReadOnly = true;
            this.txtSN.Size = new System.Drawing.Size(526, 38);
            this.txtSN.StyleController = this.layoutControl1;
            this.txtSN.TabIndex = 1;
            // 
            // txtCompName
            // 
            this.txtCompName.Location = new System.Drawing.Point(25, 93);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtCompName.Properties.Appearance.Options.UseFont = true;
            this.txtCompName.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCompName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCompName.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtCompName.Size = new System.Drawing.Size(526, 38);
            this.txtCompName.StyleController = this.layoutControl1;
            this.txtCompName.TabIndex = 2;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "يجب إدخال اسم الشركة";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.vpSupplier.SetValidationRule(this.txtCompName, conditionValidationRule1);
            // 
            // memotxtOldBusiness
            // 
            this.memotxtOldBusiness.EditValue = "";
            this.memotxtOldBusiness.Location = new System.Drawing.Point(20, 294);
            this.memotxtOldBusiness.Name = "memotxtOldBusiness";
            this.memotxtOldBusiness.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.memotxtOldBusiness.Properties.Appearance.Options.UseFont = true;
            this.memotxtOldBusiness.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.memotxtOldBusiness.Size = new System.Drawing.Size(536, 58);
            this.memotxtOldBusiness.StyleController = this.layoutControl1;
            this.memotxtOldBusiness.TabIndex = 6;
            // 
            // memClassify
            // 
            this.memClassify.EditValue = "";
            this.memClassify.Location = new System.Drawing.Point(20, 224);
            this.memClassify.Name = "memClassify";
            this.memClassify.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.memClassify.Properties.Appearance.Options.UseFont = true;
            this.memClassify.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.memClassify.Size = new System.Drawing.Size(536, 50);
            this.memClassify.StyleController = this.layoutControl1;
            this.memClassify.TabIndex = 7;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "يجب إدخال التصنيف";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.vpSupplier.SetValidationRule(this.memClassify, conditionValidationRule2);
            // 
            // cbxGover
            // 
            this.cbxGover.EditValue = "";
            this.cbxGover.Location = new System.Drawing.Point(25, 161);
            this.cbxGover.Name = "cbxGover";
            this.cbxGover.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.cbxGover.Properties.Appearance.Options.UseFont = true;
            this.cbxGover.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGover.Properties.Items.AddRange(new object[] {
            "الإسكندرية",
            "الإسماعيلية",
            "أسوان",
            "أسيوط",
            "الأقصر",
            "البحر الأحمر",
            "البحيرة",
            "بني سويف",
            "بورسعيد",
            "جنوب سيناء\t",
            "الجيزة",
            "الدقهلية\t",
            "دمياط",
            "سوهاج\t",
            "السويس",
            "الشرقية\t",
            "شمال سيناء\t",
            "الغربية",
            "الفيوم\t",
            "القاهرة\t",
            "القليوبية",
            "قنا\t",
            "كفر الشيخ\t",
            "مطروح\t",
            "المنوفية",
            "المنيا",
            "الوادي الجديد"});
            this.cbxGover.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxGover.Size = new System.Drawing.Size(526, 38);
            this.cbxGover.StyleController = this.layoutControl1;
            this.cbxGover.TabIndex = 12;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "يجب إختيار المحافظة";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.vpSupplier.SetValidationRule(this.cbxGover, conditionValidationRule3);
            // 
            // clbDoc
            // 
            this.clbDoc.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbDoc.Appearance.Options.UseFont = true;
            this.clbDoc.ColumnWidth = 20;
            this.clbDoc.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("شهادة تسجيل الضربية على القيمة المضافة"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("البطاقة الضريبية"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("السجل التجارى"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("القوائم المالية"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الموافقة الأمنية"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("سابقة خبرة")});
            this.clbDoc.Location = new System.Drawing.Point(10, 408);
            this.clbDoc.Margin = new System.Windows.Forms.Padding(0);
            this.clbDoc.Name = "clbDoc";
            this.clbDoc.Size = new System.Drawing.Size(541, 107);
            this.clbDoc.StyleController = this.layoutControl1;
            this.clbDoc.TabIndex = 11;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10,
            this.txtCompanyName,
            this.layoutControlItem6,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem8,
            this.layoutControlItem1,
            this.layout1,
            this.layoutControlItem4,
            this.layoutControlItem7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(843, 676);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem10.Control = this.txtSN;
            this.layoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem10.CustomizationFormText = "رقم المسلسل";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Padding = new DevExpress.XtraLayout.Utils.Padding(15, 15, 15, 15);
            this.layoutControlItem10.Size = new System.Drawing.Size(823, 68);
            this.layoutControlItem10.Text = "رقم المسلسل";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(255, 32);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtCompanyName.AppearanceItemCaption.Options.UseFont = true;
            this.txtCompanyName.Control = this.txtCompName;
            this.txtCompanyName.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtCompanyName.CustomizationFormText = "رقم المسلسل";
            this.txtCompanyName.Location = new System.Drawing.Point(0, 68);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Padding = new DevExpress.XtraLayout.Utils.Padding(15, 15, 15, 15);
            this.txtCompanyName.Size = new System.Drawing.Size(823, 68);
            this.txtCompanyName.Text = "اسم الشركة *";
            this.txtCompanyName.TextSize = new System.Drawing.Size(255, 32);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.memotxtOldBusiness;
            this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem6.CustomizationFormText = "التخصص";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 274);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem6.Size = new System.Drawing.Size(823, 78);
            this.layoutControlItem6.Text = "نبذة عن الأعمال السابقة";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(255, 37);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnContact;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 352);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(124, 46);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(411, 46);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.memClassify;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "التخصص";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 204);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem3.Size = new System.Drawing.Size(823, 70);
            this.layoutControlItem3.Text = "التصنيف *";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(255, 37);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem8.Control = this.cbxGover;
            this.layoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem8.CustomizationFormText = "الفئة";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 136);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(15, 15, 15, 15);
            this.layoutControlItem8.Size = new System.Drawing.Size(823, 68);
            this.layoutControlItem8.Text = "المحافظة *";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(255, 32);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnAttach;
            this.layoutControlItem1.Location = new System.Drawing.Point(411, 352);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(124, 46);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(412, 46);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layout1
            // 
            this.layout1.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.layout1.AppearanceItemCaption.Options.UseFont = true;
            this.layout1.Control = this.clbDoc;
            this.layout1.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layout1.CustomizationFormText = "التخصص";
            this.layout1.Location = new System.Drawing.Point(0, 398);
            this.layout1.MinSize = new System.Drawing.Size(359, 1);
            this.layout1.Name = "layout1";
            this.layout1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 15, 0, 0);
            this.layout1.Size = new System.Drawing.Size(823, 107);
            this.layout1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layout1.Text = "المستندات المرفقة";
            this.layout1.TextSize = new System.Drawing.Size(255, 32);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.panelControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 505);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(823, 81);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.memotxtNotes;
            this.layoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem7.CustomizationFormText = "التخصص";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 586);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem7.Size = new System.Drawing.Size(823, 70);
            this.layoutControlItem7.Text = "ملاحظات";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(255, 37);
            // 
            // SupplierInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "SupplierInput";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(843, 676);
            this.Load += new System.EventHandler(this.SupplierInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memotxtNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memotxtOldBusiness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memClassify.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGover.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem txtCompanyName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnAttach;
        private DevExpress.XtraEditors.SimpleButton btnAttachFile;
        private DevExpress.XtraEditors.SimpleButton btnContact;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        public DevExpress.XtraLayout.LayoutControl layoutControl1;
        public DevExpress.XtraEditors.ComboBoxEdit cbxGover;
        public DevExpress.XtraEditors.MemoEdit memClassify;
        public DevExpress.XtraEditors.MemoEdit memotxtNotes;
        public DevExpress.XtraEditors.TextEdit txtSN;
        public DevExpress.XtraEditors.TextEdit txtCompName;
        public DevExpress.XtraEditors.MemoEdit memotxtOldBusiness;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider vpSupplier;
        private DevExpress.XtraLayout.LayoutControlItem layout1;
        private DevExpress.XtraEditors.CheckedListBoxControl clbDoc;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.CheckBox cbxNotHandled;
        private System.Windows.Forms.CheckBox cbxHandled;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}
