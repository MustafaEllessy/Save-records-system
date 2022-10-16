using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace dvTechnicalOffice.UI.Modules
{
    public partial class ContractorInput : DevExpress.XtraEditors.XtraUserControl
    {
        public ContractorInput()
        {
            InitializeComponent();
        }
        frmContact frm;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
                 frm = new frmContact();
                frm.ShowDialog();
               
           
        }
     public static  Dictionary<string, Dictionary<string, List<string>>> divInfo;

        public string getSN() { return (Convert.ToInt32(DB.Data("select count(SN) from contractors").Rows[0][0].ToString()) + 1) + ""; }

        public void NewProcess()
        {
            try
            {
                txtSN.Text = getSN();
                txtCompName.Text = "";
                cbxGov.SelectedIndex = -1;
                memClassify.Text = "";
                memLastBus.Text = "";
                memNotes.Text = "";
                fbd.SelectedPath = "";
                clbDoc.UnCheckAll();
                cbxHandled.Checked = false;
                cbxNotHandled.Checked = false;
                for (int i = 0; i < xtraTabControl2.TabPages.Count; i++)
                {
                    ((CheckedListBoxControl)(xtraTabControl2.TabPages[i].Controls[0])).UnCheckAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool validateClassifyCat()
        {

           for (int i = 0; i < xtraTabControl2.TabPages.Count; i++) if (((CheckedListBoxControl)xtraTabControl2.TabPages[i].Controls[0]).CheckedIndices.Count > 0)
            {
                return true;
            }
            erContractor.SetError(xtraTabControl2, "يجب ان يتم اختيار تصنيف واحد على الأقل");
            return false;
        }
        private bool dealWithUdaCheck()
        {
            if (!cbxHandled.Checked && !cbxNotHandled.Checked || (cbxHandled.Checked && cbxNotHandled.Checked))
            {
                XtraMessageBox.Show("يجب تحديد التعامل مع الهيئة"); return false;
            }
            return true;
        }
        public void saveProcess()
        {
            try
            {

                if (!vpContractor.Validate()) return;
        
                if (!dealWithUdaCheck()) return;
              

                //collect data
                string sn = txtSN.Text;
                string companyName = txtCompName.Text;
                string classify = memClassify.Text;
                string gov = cbxGov.EditValue + "";
                string lastBuss = memLastBus.Text;
                List<List<int>> choosedClassifications = new List<List<int>>();
                string notes = memNotes.Text;
                string dealWithUda = cbxHandled.Checked ? "تم التعامل" : "لم يتم التعامل";
                if (!validateClassifyCat())
                {
                    XtraMessageBox.Show("يجب إختيار تصنيف واحد على الأقل");
                    return;
                }
                for (int i = 0; i < xtraTabControl2.TabPages.Count; i++)
                {
                    List<int> items = ((CheckedListBoxControl)(xtraTabControl2.TabPages[i].Controls[0])).CheckedIndices.ToList();
                  
                    choosedClassifications.Add(items);
                }
                
                List<int> docItems = clbDoc.CheckedIndices.ToList();

       


                //insert
                //1- insert to contractor table
                DB.insertToDB("contractors", new string[] { "SN", "companyName", "catBusiness", "gov", "oldBusiness", "attachFile", "dealWithUda", "notes" ,"userName"},
                    new object[]                             { sn, companyName, classify, gov, lastBuss, fbd.SelectedPath, dealWithUda, notes , userInfo.userName });
                int divIndex = getLastDivID();
                int classIndex = getLastClassID();
                int catIndex = getLastCatID();
                //2- insert to divs that has classses
                foreach (var item in divInfo)
                {
                    if (item.Value.Count != 0)
                    {
                        DB.insertToDB("divs", new string[] { "ID", "divName" }, new object[] { divIndex, item.Key });
                        DB.insertToDB("contractDiv", new string[] { "contractID", "divID" }, new object[] { sn, divIndex });
                    
                        foreach (var classItem in item.Value)
                        {
                            DB.insertToDB("classes", new string[] { "ID", "className","divID" }, new object[] { classIndex, classItem.Key ,divIndex});
                            foreach (var catItem in classItem.Value)
                            {
                                DB.insertToDB("cats", new string[] { "ID", "catName" }, new object[] {  catIndex, catItem });
                                DB.insertToDB("classCats", new string[] { "classID", "catID" }, new object[] { classIndex, catIndex });
                                catIndex++;
                            }
                            classIndex++;
                        }

                        divIndex++;
                    }

                }
                



                string docRecord = "";

                for (int j = 0; j < docItems.Count; j++)
                {
                    string docName = clbDoc.GetItemValue(docItems[j]) + "";
                    if (j == docItems.Count - 1)
                    {
                        docRecord += docName + ".";
                        break;
                    }

                    docRecord += docName + " - ";
                }

                //3- insert to reqDoc table
                DB.insertToDB("reqDocCon", new string[] { "docName", "conID" },

               new object[] { docRecord, sn });

                //4-insert to contactInfo
                if (frm != null)
                {
                    string info = frm.txtName.Text + " , " + frm.txtMobile.Text + " , " + frm.txtEmail.Text + " , " + frm.txtSite.Text + " , " + frm.txtAddress.Text + " . ";
                    DB.insertToDB("contactInfoCon", new string[] { "contactInfo", "conID" },
                    new object[] { info, sn });
                    frm.Close();
                }
                else
                {
                    DB.insertToDB("contactInfoCon", new string[] { "contactInfo", "conID" },
                  new object[] { "", sn });
                }
                /*
                //2- insert to catSpec table (categories and classifications)
                string catWithSpec = "";
                for (int i = 0; i < choosedClassifications.Count; i++)
                {
                    if (choosedClassifications[i].Count == 0) continue;
                    string catName = xtraTabControl2.TabPages[i].Text;
                    catWithSpec += (catName + " -> ");
                    for (int j = 0; j < choosedClassifications[i].Count; j++)
                    {
           
                        string specName = ((CheckedListBoxControl)(xtraTabControl2.TabPages[i].Controls[0])).GetItemValue(choosedClassifications[i][j]) + "";
                        if (j == choosedClassifications[i].Count - 1)
                        {
                            catWithSpec += specName;
                            catWithSpec += ". ";
                        }
                        else
                        {
                            catWithSpec += specName;
                            catWithSpec += " - ";
                        }
                        
                    }
                    catWithSpec += "\n";
                }
                DB.insertToDB("catSpec", new string[] { "catAndSpec", "supRel" }, new object[] { catWithSpec,  sn });

    */
                stopEr();
                XtraMessageBox.Show("تم التسجيل بنجاح");
                NewProcess();
                initializeContractDivs();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
         
        }

        private int getLastClassID()
        {
            return Convert.ToInt32(DB.Data("select count(*) from classes").Rows[0][0].ToString()) + 1;
        }

        private int getLastCatID()
        {
            return Convert.ToInt32(DB.Data("select count(*) from cats").Rows[0][0].ToString()) + 1;
        }

        private int getLastDivID()
        {
            return Convert.ToInt32( DB.Data("select count(*) from divs").Rows[0][0].ToString())+1;
        }

        private void initializeContractDivs()
        {
            divInfo = new Dictionary<string,Dictionary<string, List<string>>>();
            divInfo.Add("الشعبة الأولى", new Dictionary<string, List<string>>());
            divInfo.Add("الشعبة الثانية", new Dictionary<string, List<string>>());
            divInfo.Add("الشعبة الثالثة", new Dictionary<string, List<string>>());
            divInfo.Add("الشعبة الرابعة", new Dictionary<string, List<string>>());
            divInfo.Add("الشعبة الخامسة", new Dictionary<string, List<string>>());
            divInfo.Add("الشعبة السادسة", new Dictionary<string, List<string>>());
            divInfo.Add("الشعبة السابعة", new Dictionary<string, List<string>>());
            
        }

        public void stopEr()
        {
            erContractor.Clear();
        }

        private void memotxtOldBusiness_EditValueChanged(object sender, EventArgs e)
        {

        }
      
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            fbd.ShowDialog();
        }


        private void cbxGov_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        FolderBrowserDialog fbd;
        private void ContractorInput_Load(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();
            initializeContractDivs();
            NewProcess();
         
            for (int i = 0; i < xtraTabControl2.TabPages.Count; i++)
            {
                DataTable dt = DB.Data("select * from spiciality");
                ((CheckedListBoxControl)(xtraTabControl2.TabPages[i].Controls[0])).DataSource = dt;
                ((CheckedListBoxControl)(xtraTabControl2.TabPages[i].Controls[0])).DisplayMember = "specName";
                ((CheckedListBoxControl)(xtraTabControl2.TabPages[i].Controls[0])).ValueMember = "specName";
            }
        }
        frmContractDivsInput frmConDivs;
        public static string className = "";
        public static string divName = "";
        public static CheckState state = CheckState.Unchecked;
        private void checkedListBoxControl1_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {

             divName = xtraTabControl2.SelectedTabPage.Text;
             className = ((CheckedListBoxControl)(xtraTabControl2.TabPages[xtraTabControl2.SelectedTabPageIndex].Controls[0])).GetItemText(e.Index) + "";
            List<string> cats = new List<string>();
            state = e.State;


            if (e.State==CheckState.Checked)
            {
                frmConDivs = new frmContractDivsInput();
                frmConDivs.ShowDialog();
             
            }
            else
            {
                if (divInfo[divName].ContainsKey(className))
                {
                    divInfo[divName].Remove(className);
                }
            }
        }


        private void checkedListBoxControl1_ImeModeChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void xtraTabControl2_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            
        }
    }
}
