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
using System.IO;

namespace dvTechnicalOffice.UI.Modules
{
    public partial class SupplierInput : DevExpress.XtraEditors.XtraUserControl
    {
        public SupplierInput()
        {
            InitializeComponent();
        }
        FolderBrowserDialog fbd;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            fbd.ShowDialog();
        }
        public string getSN() { return (Convert.ToInt32(DB.Data("select count(SN) from suppliers").Rows[0][0].ToString()) + 1) + ""; }

        public void NewProcess()
        {
            txtSN.Text = getSN();
            txtCompName.Text = "";
            cbxGover.SelectedIndex = -1;
            memClassify.Text = "";
            memotxtOldBusiness.Text = "";
            memotxtNotes.Text = "";
            clbDoc.UnCheckAll();
            cbxHandled.Checked = false;
            cbxNotHandled.Checked = false;
            fbd.SelectedPath = "";
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

               if( !vpSupplier.Validate())return;
                if (!dealWithUdaCheck()) return;

                //collect data
                string sn = txtSN.Text;
                string companyName = txtCompName.Text;
                string classify = memClassify.Text;
                string lastBuss = memotxtOldBusiness.Text;
                string gov = cbxGover.EditValue + "";
       
                string notes = memotxtNotes.Text;
                string dealWithUda = cbxHandled.Checked ? "تم التعامل" : "لم يتم التعامل";
                List<int> docItems = clbDoc.CheckedIndices.ToList();

                //validate (autovalidation+er validation)
                //1- insert to supplier table
                DB.insertToDB("suppliers", new string[] { "SN", "companyName", "catBusiness", "oldBusiness", "attachFile", "dealWithUda", "notes", "gov", "userName" },
                    new object[] { sn, companyName, classify, lastBuss,fbd.SelectedPath, dealWithUda, notes, gov,userInfo.userName });

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

                //2- insert to reqDoc table
                DB.insertToDB("reqDocSup", new string[] { "docName", "supID" },
               new object[] { docRecord, sn });

                //4-insert to contactInfo
                if (frm != null)
                {
                    string info = frm.txtName.Text + " , " + frm.txtMobile.Text + " , " + frm.txtEmail.Text + " , " + frm.txtSite.Text + " , " + frm.txtAddress.Text + " . ";
                    DB.insertToDB("contactInfoSup", new string[] { "contactInfo", "supID" },
                    new object[] { info, sn });
                    frm.Close();
                }
                else
                {
                    DB.insertToDB("contactInfoSup", new string[] { "contactInfo", "supID" },
                  new object[] { "", sn });
                }


                XtraMessageBox.Show("تم التسجيل بنجاح");
                NewProcess();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }

        }


        private void memotxtNotes_EditValueChanged(object sender, EventArgs e)
        {

        }
        frmContact frm;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
          
                 frm = new frmContact();
                frm.ShowDialog();
        
        }

        private void SupplierInput_Load(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();
            NewProcess();
        }
    }
}
