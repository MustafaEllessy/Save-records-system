using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPrinting;
using dvTechnicalOffice.UI.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dvTechnicalOffice
{
    public partial class frmTechnicalOffice : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmTechnicalOffice()
        {
            InitializeComponent();
        }
        async Task LoadModuleAsync(ModuleInfo module)
        {
            await Task.Factory.StartNew(() =>
            {
                if (!fluentDesignFormContainer1.Controls.ContainsKey(module.Name))
                {
                    TutorialControlBase control = module.TModule as TutorialControlBase;
                    if (control != null)
                    {
                        control.Dock = DockStyle.Fill;
                        control.CreateWaitDialog();
                        fluentDesignFormContainer1.Invoke(new MethodInvoker(delegate ()
                        {
                            fluentDesignFormContainer1.Controls.Add(control);
                            control.BringToFront();
                        }));
                    }
                }
                else
                {
                    var control = fluentDesignFormContainer1.Controls.Find(module.Name, true);
                    if (control.Length == 1)
                    {
                        fluentDesignFormContainer1.Invoke(new MethodInvoker(delegate () { control[0].BringToFront(); }));
                    }
                }
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            btnSave.Visibility = BarItemVisibility.Always;
            btnNew.Visibility = BarItemVisibility.Always;
            btnPrint.Visibility = BarItemVisibility.Never;
            btnModeShow.Visibility = BarItemVisibility.Never;
            btnModeEdit.Visibility = BarItemVisibility.Never;

            btnModeDelete.Visibility = BarItemVisibility.Never;

            btnDelete.Visibility = BarItemVisibility.Never;
            btnEditMode.Visibility = BarItemVisibility.Never;
            btnPrintGrid.Visibility = BarItemVisibility.Never;
            btnDivsAndCats.Visibility = BarItemVisibility.Never;
            // barManager1.Items[1].Visibility = BarItemVisibility.Never;
            ofd = new OpenFileDialog();
            itemNav.Caption = $"{accordionControlElement1.Text}";
            ucContractor uContractor = new ucContractor();
            uContractor.Name = "contractor";
            fluentDesignFormContainer1.Controls.Add(uContractor);

            ucAdvisiors uAdvisiors = new ucAdvisiors();
            uAdvisiors.Name = "advisior";
            fluentDesignFormContainer1.Controls.Add(uAdvisiors);


            ucOffice uOffice = new ucOffice();
            uOffice.Name = "office";
            fluentDesignFormContainer1.Controls.Add(uOffice);

            ucMain uMain = new ucMain();
            uMain.Name = "uMain";
            fluentDesignFormContainer1.Controls.Add(uMain);

            ucSupplier uSupplier = new ucSupplier();
            uSupplier.Name = "supplier";
            fluentDesignFormContainer1.Controls.Add(uSupplier);

            fluentDesignFormContainer1.Controls["supplier"].Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Controls["contractor"].Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Controls["advisior"].Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Controls["office"].Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Controls["uMain"].Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Controls["uMain"].BringToFront();
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }
        int showPageNO = -1;
        private void accordionControlElement2Construction_Click(object sender, EventArgs e)
        {
            btnPrintGrid.Visibility = BarItemVisibility.Always;
            btnDivsAndCats.Visibility = BarItemVisibility.Always;
            btnModeShow.PerformClick();

            btnModeShow.Visibility = BarItemVisibility.Always;
            btnModeEdit.Visibility = BarItemVisibility.Always;
            btnModeDelete.Visibility = BarItemVisibility.Always;

            ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).setGrid();
            itemNav.Caption = $"{accordionControlElement1Services.Text}/{accordionControlElement2Construction.Text}";
            fluentDesignFormContainer1.Controls["contractor"].BringToFront();
            btnSave.Visibility = BarItemVisibility.Never;
            btnNew.Visibility = BarItemVisibility.Never;
            btnPrint.Visibility = BarItemVisibility.Always;
            showPageNO = 2;
            btnModeShow.Visibility = BarItemVisibility.Always;
        }

        private void accordionControlElement1Consultation_Click(object sender, EventArgs e)
        {
            btnModeShow.PerformClick();
            btnPrintGrid.Visibility = BarItemVisibility.Always;

            btnDivsAndCats.Visibility = BarItemVisibility.Never;
            btnModeShow.Visibility = BarItemVisibility.Always;
            btnModeEdit.Visibility = BarItemVisibility.Always;
            btnModeDelete.Visibility = BarItemVisibility.Always;

            DataTable dtAdvisiors = DB.Data("SELECT  advisiors.SN as [الرقم], advisiors.companyName as [الشركة], advisiors.gov as [المحافظة], advisiors.classify as [التصنيف],advisiors.oldBusiness as [أعمال سابقة], advisiors.Evaluate as [التقييم], advisiors.attachFile as [المرفق],  contactInfoAdv.contactInfo as [معلومات الاتصال],  reqDocAdv.docName as [المستندات المطلوبة], advisiors.dealWithUda as [التعامل مع الهيئة], advisiors.notes as [ملاحظات],advisiors.userName as [اسم المستخدم] FROM(advisiors left JOIN contactInfoAdv ON advisiors.SN = contactInfoAdv.advID) left JOIN reqDocAdv ON advisiors.SN = reqDocAdv.advID ORDER BY advisiors.SN;");
            ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridControl1.DataSource = dtAdvisiors;
            fluentDesignFormContainer1.Controls["advisior"].BringToFront();
            btnSave.Visibility = BarItemVisibility.Never;
            btnNew.Visibility = BarItemVisibility.Never;
            itemNav.Caption = $"{accordionControlElement1Services.Text}/{accordionControlElement1Consultation.Text}";
            btnPrint.Visibility = BarItemVisibility.Always;
            showPageNO = 1;
            btnModeShow.Visibility = BarItemVisibility.Always;

        }

        private void accordionControlElement3Supplies_Click(object sender, EventArgs e)
        {
            btnModeShow.PerformClick();
            btnPrintGrid.Visibility = BarItemVisibility.Always;
            btnDivsAndCats.Visibility = BarItemVisibility.Never;
            btnModeShow.Visibility = BarItemVisibility.Always;
            btnModeEdit.Visibility = BarItemVisibility.Always;
            btnModeDelete.Visibility = BarItemVisibility.Always;

            DataTable dtSuppliers = DB.Data("SELECT suppliers.SN as [الرقم] , suppliers.companyName as [الشركة], suppliers.catBusiness as [تصنيف الأعمال], suppliers.oldBusiness as [الأعمال السابقة], suppliers.attachFile as [المرفق], suppliers.gov as [المحافظة], contactInfoSup.contactInfo as [معلومات الاتصال], reqDocSup.docName as [المستندات المطلوبة], suppliers.dealWithUda as [التعامل مع الهيئة], suppliers.notes as [الملاحظات], suppliers.userName as [اسم المستخدم] FROM(suppliers left JOIN contactInfoSup ON suppliers.SN = contactInfoSup.supID) left JOIN reqDocSup ON suppliers.SN = reqDocSup.supID ORDER BY suppliers.SN;");
            ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridControl1.DataSource = dtSuppliers;
            fluentDesignFormContainer1.Controls["supplier"].BringToFront();
            btnSave.Visibility = BarItemVisibility.Never;
            btnNew.Visibility = BarItemVisibility.Never;
            itemNav.Caption = $"{accordionControlElement1Services.Text}/{z.Text}";
            btnPrint.Visibility = BarItemVisibility.Always;
            showPageNO = 3;
            btnModeShow.Visibility = BarItemVisibility.Always;

        }


        private void accordionControlElement1Busness_Click(object sender, EventArgs e)
        {
          
            fluentDesignFormContainer1.Controls["layoutControl1"].BringToFront();
            // barManager1.DockingEnabled = true;
            btnSave.Visibility = BarItemVisibility.Always;
            btnNew.Visibility = BarItemVisibility.Always;
            btnPrint.Visibility = BarItemVisibility.Never;

        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
        }

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {



        }
        OpenFileDialog ofd;

        private void insert()
        {
            // throw new NotImplementedException();
        }


        private void accordionControlElement1Services_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            /*try
            {
        
                string serviceType = cbxServiceType.EditValue   != null ? cbxServiceType.EditValue.ToString(): string.Empty; 
                string serialNO = txtSN.Text;
                string companyName = txtCompName.Text;
                string catBusiness = txtCatBusiness.Text;
                string cat = txtCat.Text;
                string notes = memotxtNotes.Text;
                string oldBusiness = memotxtOldBusiness.Text;
                string speciality = memotxtSpecial.Text;
                string filePath = ofd.FileName;
                if (!validateInput(serviceType, serialNO, companyName, catBusiness, cat, notes, oldBusiness, speciality, filePath)) return;
                insertData(serviceType,serialNO, companyName, catBusiness, cat, notes, oldBusiness, speciality, filePath);
                MessageBox.Show("تم حفظ البيانات");
                clearAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }*/

        }

        private void insertData(string serviceType, string serialNO, string companyName, string catBusiness, string cat, string notes, string oldBusiness, string speciality, string filePath)
        {
            try
            {
                DB.insertToDB("DataContent", new string[] { "serviceType", "SN", "companyName", "catBusiness", "catName", "notes", "oldBusiness", "speciality", "filePath" },
         new object[] { serviceType, serialNO, companyName, catBusiness, cat, notes, oldBusiness, speciality, filePath });
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnAttachFile_Click_1(object sender, EventArgs e)
        {
            ofd.Multiselect = false;
            ofd.ShowDialog();
        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {


        }



        private void accordionControlElement1_Click_1(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls["uMain"].BringToFront();
            btnDivsAndCats.Visibility = BarItemVisibility.Never;
            btnSave.Visibility = BarItemVisibility.Never;
            btnEditMode.Visibility = BarItemVisibility.Never;
            btnPrintGrid.Visibility = BarItemVisibility.Never;
            ((ucMain)fluentDesignFormContainer1.Controls["uMain"]).btnNewProcess.PerformClick();
            btnModeShow.Visibility = BarItemVisibility.Never;
            btnModeEdit.Visibility = BarItemVisibility.Never;
            btnModeDelete.Visibility = BarItemVisibility.Never;

        }

        private void accordionControlElement2Ofiice_Click(object sender, EventArgs e)
        {
            btnModeShow.PerformClick();
            btnPrintGrid.Visibility = BarItemVisibility.Always;
            btnDivsAndCats.Visibility = BarItemVisibility.Never;
            btnModeShow.Visibility = BarItemVisibility.Always;
            btnModeEdit.Visibility = BarItemVisibility.Always;
            btnModeDelete.Visibility = BarItemVisibility.Always;

            DataTable dtOffice = DB.Data("SELECT office.SN as [الرقم], office.companyName as [الشركة], office.catBusiness as [التصنيف], office.oldBusiness as [الاعمال السابقة], office.attachFile as [المرفق],  office.gov as [المحافظة], contactInfoOffice.contactInfo as [معلومات الاتصال], reqDocOffice.docName as [المستندات المطلوبة], office.dealWithUda as [التعامل مع الهيئة], office.notes as [الملاحظات], office.userName as [اسم السمتخدم] FROM(office left JOIN contactInfoOffice ON office.SN = contactInfoOffice.officeID) left JOIN reqDocOffice ON office.SN = reqDocOffice.officeID ORDER BY office.SN;");
            ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridControl1.DataSource = dtOffice;
            fluentDesignFormContainer1.Controls["office"].BringToFront();
            btnSave.Visibility = BarItemVisibility.Never;
            btnNew.Visibility = BarItemVisibility.Never;
            itemNav.Caption = $"{accordionControlElement1Services.Text}/{accordionControlElement2Ofiice.Text}";
            btnPrint.Visibility = BarItemVisibility.Always;
            showPageNO = 4;
            btnModeShow.Visibility = BarItemVisibility.Always;

        }
        bool isEdited = false;
        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                isEdited = true;
                applyEditingProcess();

                if(isEdited)
                XtraMessageBox.Show("تم التعديل بنجاح");
              

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);

            }

        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
        }
        Dictionary<string, Dictionary<string, List<string>>> divInfEdit;

        private void applyEditingProcess()
        {
            if (showPageNO == 1)
            {
                foreach (int item in ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).editedIndeces)
                {
                    if (!((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).deletedIndeces.Contains(item))
                    {
                        object[] row = getRow(item);
                        string sn = row[0] + "";
                        string companyName = row[1] + "";
                        string gov = row[2] + "";
                        string classify = row[3] + "";
                        string oldBusiness = row[4] + "";
                        string evaluate = row[5] + "";
                        string attachFile = row[6] + "";
                        string contactInfo = row[7] + "";
                        string docName = row[8] + "";
                        string dealWithUda = row[9] + "";
                        string notes = row[10] + "";
                        if (dealWithUda == "")
                        {
                            isEdited = false;
                            XtraMessageBox.Show("يجب تحديد التعامل مع الهيئة"); return;
                        }
                        if (companyName=="")
                        {
                            isEdited = false;
                            XtraMessageBox.Show("يجب إدخال اسم الشركة");return;
                        }
                      
                        DB.affectBuild("UPDATE (advisiors left JOIN contactInfoAdv ON advisiors.SN = contactInfoAdv.advID) left JOIN reqDocAdv ON advisiors.SN = reqDocAdv.advID SET advisiors.companyName = '" + companyName + "', advisiors.gov = '" + gov + "', advisiors.dealWithUda = '" + dealWithUda + "', advisiors.classify = '" + classify + "', advisiors.oldBusiness = '" + oldBusiness + "', advisiors.Evaluate ='" + evaluate + "', advisiors.attachFile = '" + attachFile + "', advisiors.notes = '" + notes + "', contactInfoAdv.contactInfo = '" + contactInfo + "', reqDocAdv.docName = '" + docName + "' WHERE(([advisiors].[SN] = " + sn + "));");
                      
                    }
                }
            }
            else if (showPageNO == 2)
            {
                foreach (int item in ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).editedIndeces)
                {
                    if (!((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).deletedIndeces.Contains(item))
                    {
                        object[] row = getRow(item);
                        string sn = row[0] + "";
                        string companyName = row[1] + "";
                        string classify = row[2] + "";
                        string gov = row[3] + "";
                        string oldBusiness = row[4] + "";
                        string attachFile = row[5] + "";
                        string contactInfo = row[6] + "";
                        string docName = row[7] + "";
                        string dealWithUda = row[8] + "";
                        string divsInfo = row[9] + "";
                        string notes = row[10] + "";
                        string[] divs = divsInfo.Split('\n');
                        if (dealWithUda == "")
                        {
                            XtraMessageBox.Show("يجب تحديد التعامل مع الهيئة"); return;
                        }
                        if (companyName == "")
                        {
                            XtraMessageBox.Show("يجب إدخال اسم الشركة"); return;
                        }
                    
                        divInfEdit = new Dictionary<string, Dictionary<string, List<string>>>();

                        for (int i = 0; i < divs.Length; i++)
                        {
                            string[] divN = divs[i].Split('/');
                            string divName = divN[0];
                            divInfEdit.Add(divName, new Dictionary<string, List<string>>());

                            string[] cats;
                            string catName = "";
                            string[] divC = divN[1].Split('،');
                            for (int k = 0; k < divC.Length; k++)
                            {
                                string[] divCat = divC[k].Split(':');
                                catName = divCat[0];
                                cats = divCat[1].Split('-');
                                List<string> catsList = cats.ToList<string>();
                                if (divInfEdit[divName].ContainsKey(catName)) divInfEdit[divName][catName] = catsList;
                                else
                                {
                                    divInfEdit[divName].Add(catName, catsList);
                                }
                            }

                        }

                        if (divInfEdit.Count==0)
                        {
                            XtraMessageBox.Show("يجب إختيار شعبة واحدة على الأقل"); return;
                        }
                        DataTable dtDvis = DB.Data("select divID from contractDiv where contractID = " + sn);
          
                        string inClauseDiv = " in (";
                        for (int i = 0; i < dtDvis.Rows.Count; i++)
                        {
                            if (i == dtDvis.Rows.Count - 1)
                            {
                                inClauseDiv += (dtDvis.Rows[i][0].ToString() + ")");
                                continue;
                            }
                            inClauseDiv += (dtDvis.Rows[i][0].ToString() + ",");
                        }

                        DataTable dtClasses = DB.Data("select ID from classes where divID" + inClauseDiv);
                        string inClauseClass = " in (";
                        for (int i = 0; i < dtClasses.Rows.Count; i++)
                        {
                            if (i == dtClasses.Rows.Count - 1)
                            {
                                inClauseClass += (dtClasses.Rows[i][0].ToString() + ")");
                                continue;
                            }
                            inClauseClass += (dtClasses.Rows[i][0].ToString() + ",");
                        }
                        DataTable dtCats = DB.Data("select catID from classCats where classID" + inClauseClass);

                        string inClauseCat = " in (";
                        for (int i = 0; i < dtCats.Rows.Count; i++)
                        {
                            if (i == dtCats.Rows.Count - 1)
                            {
                                inClauseCat += (dtCats.Rows[i][0].ToString() + ")");
                                continue;
                            }
                            inClauseCat += (dtCats.Rows[i][0].ToString() + ",");
                        }

                        DB.affectBuild("delete from contractDiv where contractID = " + sn);
                        DB.affectBuild("delete from classCats where classID" + inClauseClass);
                        DB.affectBuild("delete from classes where divID" + inClauseDiv);
                        DB.affectBuild("delete from cats where ID" + inClauseCat);
                        DB.affectBuild("delete from divs where ID" + inClauseDiv);
                        int divIndex = getLastDivID();
                        int classIndex =getLastClassID();
                        int catIndex = getLastCatID();
                        bool di = false, cl = false, ca = false;
                        //2- insert to divs that has classses
                        foreach (var ITEM in divInfEdit)
                        {
                            di = true;
                            if (ITEM.Value.Count != 0)
                            {
                                DB.insertToDB("divs", new string[] { "ID", "divName" }, new object[] {divIndex, ITEM.Key });
                                DB.insertToDB("contractDiv", new string[] { "contractID", "divID" }, new object[] { sn, divIndex });

                                foreach (var classItem in ITEM.Value)
                                {
                                    cl = true;
                                    DB.insertToDB("classes", new string[] { "ID", "className", "divID" }, new object[] { classIndex, classItem.Key, divIndex });
                                    foreach (var catItem in classItem.Value)
                                    {
                                        DB.insertToDB("cats", new string[] { "ID", "catName" }, new object[] {catIndex, catItem });
                                        DB.insertToDB("classCats", new string[] { "classID", "catID" }, new object[] {classIndex,  catIndex });
                                        catIndex++;
                                        ca = true;
                                    }
                                    classIndex++;
                                }

                                divIndex++;
                            }

                        }
                        if(!(di && cl && ca))
                        {
                            XtraMessageBox.Show(" يجب تواجد فئة وتصنيف وشعبة على الأقل");return;
                        }
                       
                        DB.affectBuild("UPDATE contractors left JOIN contactInfoCon ON contractors.SN = contactInfoCon.conID SET contactInfoCon.contactInfo = '" + contactInfo + "' WHERE(([contractors].[SN] = " + sn + "));");
                        DB.affectBuild("UPDATE contractors left JOIN reqDocCon ON contractors.SN = reqDocCon.conID SET reqDocCon.docName = '" + docName + "'  WHERE [contractors].[SN] = " + sn);
                        DB.affectBuild("UPDATE contractors SET contractors.companyName = '" + companyName + "', contractors.catBusiness = '" + classify + "', contractors.gov = '" + gov + "', contractors.oldBusiness = '" + oldBusiness + "', contractors.attachFile = '" + attachFile + "', contractors.dealWithUda = '" + dealWithUda + "', contractors.notes = '" + notes + "' WHERE contractors.SN=" + sn + "; ");
                    }
                }
            }
            else if (showPageNO == 3)
            {
                foreach (int item in ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).editedIndeces)
                {
                    if (!((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).deletedIndeces.Contains(item))
                    {
                        object[] row = getRow(item);
                        string sn = row[0] + "";
                        string companyName = row[1] + "";
                        string classify = row[2] + "";
                        string oldBusiness = row[3] + "";
                        string attachFile = row[4] + "";
                        string gov = row[5] + "";
                        string contactInfo = row[6] + "";
                        string docName = row[7] + "";
                        string dealWithUda = row[8] + "";
                        string notes = row[9] + "";
                        if (dealWithUda == "")
                        {
                            XtraMessageBox.Show("يجب تحديد التعامل مع الهيئة"); return;
                        }
                        if (companyName == "")
                        {
                            XtraMessageBox.Show("يجب إدخال اسم الشركة"); return;
                        }
                      
                        DB.affectBuild("UPDATE (suppliers left JOIN contactInfoSup ON suppliers.SN = contactInfoSup.supID) left JOIN reqDocSup ON suppliers.SN = reqDocSup.supID SET suppliers.companyName = '" + companyName + "', suppliers.catBusiness = '" + classify + "', suppliers.oldBusiness = '" + oldBusiness + "', suppliers.attachFile = '" + attachFile + "', suppliers.notes = '" + notes + "', suppliers.gov = '" + gov + "', contactInfoSup.contactInfo = '" + contactInfo + "', reqDocSup.docName = '" + docName + "', suppliers.dealWithUda = '" + dealWithUda + "' WHERE(([suppliers].[SN] = " + sn + "));");
                    }
                }
            }
            else if (showPageNO == 4)
            {
                foreach (int item in ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).editedIndeces)
                {
                    if (!((ucOffice)(fluentDesignFormContainer1.Controls["office"])).deletedIndeces.Contains(item))
                    {
                        object[] row = getRow(item);
                        string sn = row[0] + "";
                        string companyName = row[1] + "";
                        string classify = row[2] + "";
                        string oldBusiness = row[3] + "";
                        string attachFile = row[4] + "";
                        string gov = row[5] + "";
                        string contactInfo = row[6] + "";
                        string docName = row[7] + "";
                        string dealWithUda = row[8] + "";
                        string notes = row[9] + "";
                        if (companyName == "")
                        {
                            XtraMessageBox.Show("يجب إدخال اسم الشركة"); return;
                        }
                 
                        if (dealWithUda == "")
                        {
                            XtraMessageBox.Show("يجب تحديد التعامل مع الهيئة"); return;
                        }
                        DB.affectBuild("UPDATE (office left JOIN contactInfoOffice ON office.SN = contactInfoOffice.officeID) left JOIN reqDocOffice ON office.SN = reqDocOffice.officeID SET  office.companyName = '" + companyName + "', office.catBusiness = '" + classify + "', office.dealWithUda = '" + dealWithUda +"', office.oldBusiness = '" + oldBusiness + "', office.attachFile = '" + attachFile + "', office.notes = '" + notes + "', office.gov = '" + gov + "', contactInfoOffice.contactInfo = '" + contactInfo + "', reqDocOffice.docName = '" + docName + "' WHERE(([office].[SN] = " + sn + ")); ");
                    }
                }
            }

        }
        //  List<string> divsName = new List<string> { "الشعبة الأولى", "الشعبة الثانية" , "الشعبة الثالثة" , "الشعبة الرابعة" , "الشعبة الخامسة" , "الشعبة السادسة" , "الشعبة السابعة" };
        // List<string> className = new List<string> { "الفئة الأولى", "الفئة الثانية", "الفئة الثالثة", "الفئة الرابعة", "الفئة الخامسة", "الفئة السادسة", "الفئة السابعة" };

        private void ValidateDivInfo()
        {

        }

        private int getLastClassID()
        {
            DataTable dtResult = DB.Data("SELECT TOP 1 * FROM classes ORDER BY ID DESC");
            if(dtResult.Rows.Count==0)
            {
                return 1;
            }
            else
                return Convert.ToInt32(dtResult.Rows[0][0].ToString()) + 1;


        }

        private int getLastCatID()
        {
            DataTable dtResult = DB.Data("SELECT TOP 1 * FROM cats ORDER BY ID DESC");
            if (dtResult.Rows.Count == 0)
            {
                return 1;
            }
            else
                return Convert.ToInt32(dtResult.Rows[0][0].ToString()) + 1;
        }

        private int getLastDivID()
        {
            DataTable dtResult = DB.Data("SELECT TOP 1 * FROM divs ORDER BY ID DESC");
            if (dtResult.Rows.Count == 0)
            {
                return 1;
            }
            else
                return Convert.ToInt32(dtResult.Rows[0][0].ToString()) + 1;
        }

        private object[] getRow(int item)
        {

            if (showPageNO == 1)
            {
                object e0 = ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.GetRowCellValue(item, ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[0]);
                object e1 = ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.GetRowCellValue(item, ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[1]);
                object e2 = ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.GetRowCellValue(item, ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[2]);
                object e3 = ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.GetRowCellValue(item, ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[3]);
                object e4 = ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.GetRowCellValue(item, ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[4]);
                object e5 = ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.GetRowCellValue(item, ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[5]);
                object e6 = ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.GetRowCellValue(item, ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[6]);
                object e7 = ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.GetRowCellValue(item, ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[7]);
                object e8 = ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.GetRowCellValue(item, ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[8]);
                object e9 = ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.GetRowCellValue(item, ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[9]);
                object e10 = ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.GetRowCellValue(item,((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[10]);
                return new object[] { e0, e1, e2, e3, e4, e5, e6, e7, e8, e9,e10 };
            }
            else if (showPageNO == 2)
            {
                object e0 = ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.GetRowCellValue(item, ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Columns[0]);
                object e1 = ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.GetRowCellValue(item, ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Columns[1]);
                object e2 = ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.GetRowCellValue(item, ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Columns[2]);
                object e3 = ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.GetRowCellValue(item, ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Columns[3]);
                object e4 = ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.GetRowCellValue(item, ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Columns[4]);
                object e5 = ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.GetRowCellValue(item, ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Columns[5]);
                object e6 = ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.GetRowCellValue(item, ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Columns[6]);
                object e7 = ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.GetRowCellValue(item, ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Columns[7]);
                object e8 = ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.GetRowCellValue(item, ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Columns[8]);
                object e9 = ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.GetRowCellValue(item, ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Columns[9]);
                object e10 = ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.GetRowCellValue(item, ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Columns[10]);

                return new object[] { e0, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10 };
            }
            else if (showPageNO == 3)
            {
                object e0 = ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.GetRowCellValue(item, ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.Columns[0]);
                object e1 = ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.GetRowCellValue(item, ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.Columns[1]);
                object e2 = ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.GetRowCellValue(item, ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.Columns[2]);
                object e3 = ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.GetRowCellValue(item, ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.Columns[3]);
                object e4 = ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.GetRowCellValue(item, ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.Columns[4]);
                object e5 = ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.GetRowCellValue(item, ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.Columns[5]);
                object e6 = ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.GetRowCellValue(item, ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.Columns[6]);
                object e7 = ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.GetRowCellValue(item, ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.Columns[7]);
                object e8 = ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.GetRowCellValue(item, ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.Columns[8]);
                object e9 = ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.GetRowCellValue(item, ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.Columns[9]);
                return new object[] { e0, e1, e2, e3, e4, e5, e6, e7, e8, e9 };
            }
            else
            {
                object e0 = ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.GetRowCellValue(item, ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.Columns[0]);
                object e1 = ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.GetRowCellValue(item, ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.Columns[1]);
                object e2 = ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.GetRowCellValue(item, ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.Columns[2]);
                object e3 = ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.GetRowCellValue(item, ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.Columns[3]);
                object e4 = ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.GetRowCellValue(item, ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.Columns[4]);
                object e5 = ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.GetRowCellValue(item, ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.Columns[5]);
                object e6 = ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.GetRowCellValue(item, ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.Columns[6]);
                object e7 = ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.GetRowCellValue(item, ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.Columns[7]);
                object e8 = ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.GetRowCellValue(item, ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.Columns[8]);
                object e9 = ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.GetRowCellValue(item, ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.Columns[9]);
                return new object[] { e0, e1, e2, e3, e4, e5, e6, e7, e8,e9 };
            }

        }



        private void btnMode_ItemClick(object sender, ItemClickEventArgs e)
        {
          
                btnPrintGrid.Visibility = BarItemVisibility.Always;
                btnEditMode.Visibility = BarItemVisibility.Never;
                btnDelete.Visibility = BarItemVisibility.Never;
                if (showPageNO == 1)
                {
                    ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[6].ColumnEdit = new RepositoryItemButtonEdit();
                    ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
                    ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.OptionsBehavior.Editable = false;
                    ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).canDelete = false;

                }
                else if (showPageNO == 2)
                {
                    btnDivsAndCats.Visibility = BarItemVisibility.Always;
                    ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Columns[5].ColumnEdit = new RepositoryItemButtonEdit();
                    ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
                    ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.OptionsBehavior.Editable = false;
                    ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).canDelete = false;

                }
                else if (showPageNO == 3)
                {
                    ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.Columns[4].ColumnEdit = new RepositoryItemButtonEdit();
                    ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
                    ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.OptionsBehavior.Editable = false;
                    ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).canDelete = false;
                }
                else if (showPageNO == 4)
                {
                    ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.Columns[4].ColumnEdit = new RepositoryItemButtonEdit();
                    ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
                    ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.OptionsBehavior.Editable = false;
                    ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).canDelete = false;

                }
            
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            deletingProcess();
        }

        private void deletingProcess()
        {
            try
            {
                if (showPageNO == 1)
                {
                    string inClause = " in (";

                    for (int i = 0; i < ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).deletedIndeces.Count; i++)
                    {
                        inClause += (((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).deletedIndeces[i] + ",");
                        if (i == ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).deletedIndeces.Count - 1)
                        {
                            inClause += (((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).deletedIndeces[i] + ")"); ;
                        }
                    }
                    if (((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).deletedIndeces.Count > 0)
                    {
                        DB.affectBuild("delete from reqDocAdv where advID" + inClause);
                        DB.affectBuild("delete from contactInfoAdv where advID" + inClause);
                        DB.affectBuild("delete from advisiors where SN" + inClause);
                        XtraMessageBox.Show("تم الحذف بنجاح");
                    }
                }
                else if (showPageNO == 2)
                {
                    string inClause = " in (";

                    for (int i = 0; i < ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).deletedIndeces.Count; i++)
                    {
                        if (i == ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).deletedIndeces.Count - 1)
                        {
                            inClause += (((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).deletedIndeces[i] + ")");
                            continue;
                        }
                        inClause += (((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).deletedIndeces[i] + ",");

                    }
                    if (((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).deletedIndeces.Count > 0)
                    {
                        DataTable dtDvis = DB.Data("select divID from contractDiv where contractID" + inClause);
                        string inClauseDiv = " in (";
                        for (int i = 0; i < dtDvis.Rows.Count; i++)
                        {
                            if (i == dtDvis.Rows.Count - 1)
                            {
                                inClauseDiv += (dtDvis.Rows[i][0].ToString() + ")");
                                continue;
                            }
                            inClauseDiv += (dtDvis.Rows[i][0].ToString() + ",");
                        }

                        DataTable dtClasses = DB.Data("select ID from classes where divID" + inClauseDiv);
                        string inClauseClass = " in (";
                        for (int i = 0; i < dtClasses.Rows.Count; i++)
                        {
                            if (i == dtClasses.Rows.Count - 1)
                            {
                                inClauseClass += (dtClasses.Rows[i][0].ToString() + ")");
                                continue;
                            }
                            inClauseClass += (dtClasses.Rows[i][0].ToString() + ",");
                        }
                        DataTable dtCats = DB.Data("select catID from classCats where classID" + inClauseClass);

                        string inClauseCat = " in (";
                        for (int i = 0; i < dtCats.Rows.Count; i++)
                        {
                            if (i == dtCats.Rows.Count - 1)
                            {
                                inClauseCat += (dtCats.Rows[i][0].ToString() + ")");
                                continue;
                            }
                            inClauseCat += (dtCats.Rows[i][0].ToString() + ",");
                        }
                        DB.affectBuild("delete from contractDiv where contractID" + inClause);
                        DB.affectBuild("delete from classCats where classID" + inClauseClass);
                        DB.affectBuild("delete from classes where divID" + inClauseDiv);
                        DB.affectBuild("delete from cats where ID" + inClauseCat);
                        DB.affectBuild("delete from divs where ID" + inClauseDiv);
                        DB.affectBuild("delete from reqDocCon where conID" + inClause);
                        DB.affectBuild("delete from contactInfoCon where conID" + inClause);
                        DB.affectBuild("delete from contractors where SN" + inClause);
                        XtraMessageBox.Show("تم الحذف بنجاح");
                    }
                }
                else if (showPageNO == 3)
                {
                    string inClause = " in (";

                    for (int i = 0; i < ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).deletedIndeces.Count; i++)
                    {
                        inClause += (((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).deletedIndeces[i] + ",");
                        if (i == ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).deletedIndeces.Count - 1)
                        {
                            inClause += (((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).deletedIndeces[i] + ")"); ;
                        }
                    }
                    if (((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).deletedIndeces.Count > 0)
                    {
                        DB.affectBuild("delete from reqDocSup where supID" + inClause);
                        DB.affectBuild("delete from contactInfoSup where supID" + inClause);
                        DB.affectBuild("delete from suppliers where SN" + inClause);
                        XtraMessageBox.Show("تم الحذف بنجاح");
                    }
                }
                else if (showPageNO == 4)
                {
                    string inClause = " in (";

                    for (int i = 0; i < ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).deletedIndeces.Count; i++)
                    {
                        inClause += (((ucOffice)(fluentDesignFormContainer1.Controls["office"])).deletedIndeces[i] + ",");
                        if (i == ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).deletedIndeces.Count - 1)
                        {
                            inClause += (((ucOffice)(fluentDesignFormContainer1.Controls["office"])).deletedIndeces[i] + ")"); ;
                        }
                    }
                    if (((ucOffice)(fluentDesignFormContainer1.Controls["office"])).deletedIndeces.Count > 0)
                    {
                        DB.affectBuild("delete from reqDocOffice where officeID" + inClause);
                        DB.affectBuild("delete from contactInfoOffice where officeID" + inClause);
                        DB.affectBuild("delete from office where SN" + inClause);
                        XtraMessageBox.Show("تم الحذف بنجاح");
                    }
                }

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }



        }

        private void btnPrintGrid_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (showPageNO == 1)
            {
                ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[6].Visible = false;
                ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[10].Visible = false;
                ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Print();
                ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[6].Visible = true;
                ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[10].Visible = true;

            }
            else if (showPageNO == 2)
            {
                ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Columns[5].Visible = false;
                ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Columns[10].Visible = false;
                ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Print();
                ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Columns[5].Visible = true;
                ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Columns[10].Visible = true;
            }
            else if (showPageNO == 3)
            {
                ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.Columns[9].Visible = false;
                ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.Columns[4].Visible = false;
                ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.Print();
                ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.Columns[9].Visible = true;
                ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.Columns[4].Visible = true;
            }
            else if (showPageNO == 4)
            {
                ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.Columns[9].Visible = false;
                ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.Columns[4].Visible = false;
                ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.Print();
                ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.Columns[9].Visible = true;
                ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.Columns[4].Visible = true;

            }

        }

        private void btnDivsAndCats_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDivAndCat frm = new frmDivAndCat();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.Cancel && frm.ok)
            {
                List<string> divs = new List<string>();
                List<string> cats = new List<string>();
                DataTable dtFilter = new DataTable();
                dtFilter.Columns.Add("الرقم", typeof(int));
                dtFilter.Columns.Add("الشركة", typeof(string));
                dtFilter.Columns.Add("تصنيف الأعمال", typeof(string));
                dtFilter.Columns.Add("المحافظة", typeof(string));
                dtFilter.Columns.Add("الأعمال السابقة", typeof(string));
                dtFilter.Columns.Add("المرفقات", typeof(string));
                dtFilter.Columns.Add("معلومات الأتصال", typeof(string));
                dtFilter.Columns.Add("المستندات", typeof(string));
                dtFilter.Columns.Add("التعامل مع الهيئة", typeof(string));
                dtFilter.Columns.Add("الشعبة والتصنيف والفئات", typeof(string));
                dtFilter.Columns.Add("الملاحظات", typeof(string));
                dtFilter.Columns.Add("اسم المستخدم", typeof(string));
                for (int i = 0; i < frm.clbDivision.CheckedIndices.Count; i++)
                {
                    divs.Add(frm.clbDivision.GetItemText(frm.clbDivision.CheckedIndices[i]));
                }
                for (int i = 0; i < frm.clbCat.CheckedIndices.Count; i++)
                {
                    cats.Add(frm.clbCat.GetItemText(frm.clbCat.CheckedIndices[i]));
                }
                for (int i = 0; i < ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).dtContractors.Rows.Count; i++)
                {
                    string gridValue = ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).dtContractors.Rows[i][ "الشعبة والتصنيف والفئات"].ToString();
                    //check
                    bool isOk = true;
                    for (int m = 0; m < divs.Count; m++)
                    {
                        if (!gridValue.Contains(divs[m]))
                        {
                            isOk = false;
                        }
                    }
                    if (!isOk) continue;
                    for (int m = 0; m < cats.Count; m++)
                    {
                        if (!gridValue.Contains(cats[m]))
                        {
                            isOk = false;
                        }
                    }
 

                    if (!isOk) continue;
                    //if exists
                    object[] row = new object[]
                    {
                        Convert.ToInt32( ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).dtContractors.Rows[i][ "الرقم"].ToString()),
                        ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).dtContractors.Rows[i][ "الشركة"].ToString(),
                        ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).dtContractors.Rows[i][ "تصنيف الأعمال"].ToString(),
                        ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).dtContractors.Rows[i][ "المحافظة"].ToString(),
                        ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).dtContractors.Rows[i]["الأعمال السابقة"].ToString(),
                        ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).dtContractors.Rows[i][ "المرفقات"].ToString(),
                        ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).dtContractors.Rows[i]["معلومات الأتصال"].ToString(),
                        ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).dtContractors.Rows[i]["المستندات"].ToString(),
                        ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).dtContractors.Rows[i][ "التعامل مع الهيئة"].ToString(),
                        ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).dtContractors.Rows[i][ "الشعبة والتصنيف والفئات"].ToString(),
                        ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).dtContractors.Rows[i][ "الملاحظات"].ToString(),
                        ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).dtContractors.Rows[i][ "اسم المستخدم"].ToString()

                    };
                    dtFilter.Rows.Add(row);
                }
                  ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridControl1.DataSource = dtFilter;
                frm.Close();
            }
        }

        private void btnModeEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(userInfo.userName!= "Mahmoud" && userInfo.userName != "Admin")
            {
                XtraMessageBox.Show("لا تملك صلاحيات التعديل");
                return;
            }
            btnPrintGrid.Visibility = BarItemVisibility.Never;
            btnEditMode.Visibility = BarItemVisibility.Always;
            btnDelete.Visibility = BarItemVisibility.Never;
            if (showPageNO == 1)
            {
                ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[6].ColumnEdit = new RepositoryItemMemoEdit();
                ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.OptionsSelection.EnableAppearanceFocusedCell = true;
                ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).canDelete = false;
                ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.OptionsBehavior.Editable = true;
                ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[0].OptionsColumn.AllowEdit = false;
                ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[11].OptionsColumn.AllowEdit = false;

            }
            else if (showPageNO == 2)
            {
                btnDivsAndCats.Visibility = BarItemVisibility.Never;
                ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Columns[5].ColumnEdit = new RepositoryItemMemoEdit();
                ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).canDelete = false;
                ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.OptionsSelection.EnableAppearanceFocusedCell = true;
                ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.OptionsBehavior.Editable = true;
                ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Columns[0].OptionsColumn.AllowEdit = false;
                ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[11].OptionsColumn.AllowEdit = false;

            }
            else if (showPageNO == 3)
            {
                ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.Columns[4].ColumnEdit = new RepositoryItemMemoEdit();
                ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).canDelete = false;
                ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.OptionsSelection.EnableAppearanceFocusedCell = true;
                ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.OptionsBehavior.Editable = true;
                ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.Columns[0].OptionsColumn.AllowEdit = false;
                ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[10].OptionsColumn.AllowEdit = false;

            }
            else if (showPageNO == 4)
            {
                ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.OptionsSelection.EnableAppearanceFocusedCell = true;
                ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).canDelete = false;
                ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.Columns[4].ColumnEdit = new RepositoryItemMemoEdit();
                ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.OptionsBehavior.Editable = true;
                ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.Columns[0].OptionsColumn.AllowEdit = false;
                ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[10].OptionsColumn.AllowEdit = false;


            }
        }

        private void btnModeDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (userInfo.userName != "Mahmoud" && userInfo.userName != "Admin")
            {
                XtraMessageBox.Show("لا تملك صلاحيات الحذف");
                return;
            }
            btnPrintGrid.Visibility = BarItemVisibility.Never;
            btnEditMode.Visibility = BarItemVisibility.Never;
            btnDelete.Visibility = BarItemVisibility.Always;
            if (showPageNO == 1)
            {
                ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.Columns[6].ColumnEdit = new RepositoryItemButtonEdit();
                ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
                ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).gridView1.OptionsBehavior.Editable = false;
                ((ucAdvisiors)(fluentDesignFormContainer1.Controls["advisior"])).canDelete = true;

            }
            else if (showPageNO == 2)
            {
                btnDivsAndCats.Visibility = BarItemVisibility.Never;
                ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.Columns[5].ColumnEdit = new RepositoryItemButtonEdit();
                ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
                ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).gridView1.OptionsBehavior.Editable = false;
                ((ucContractor)(fluentDesignFormContainer1.Controls["contractor"])).canDelete = true;

            }
            else if (showPageNO == 3)
            {
                ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.Columns[4].ColumnEdit = new RepositoryItemButtonEdit();
                ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
                ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).gridView1.OptionsBehavior.Editable = false;
                ((ucSupplier)(fluentDesignFormContainer1.Controls["supplier"])).canDelete = true;
            }
            else if (showPageNO == 4)
            {
                ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.Columns[4].ColumnEdit = new RepositoryItemButtonEdit();
                ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
                ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).gridView1.OptionsBehavior.Editable = false;
                ((ucOffice)(fluentDesignFormContainer1.Controls["office"])).canDelete = true;

            }
        }

        private void frmTechnicalOffice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

