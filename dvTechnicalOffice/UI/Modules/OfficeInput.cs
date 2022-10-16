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
    public partial class OfficeInput : DevExpress.XtraEditors.XtraUserControl
    {
        public OfficeInput()
        {
            InitializeComponent();
        }
        frmContact frm;
        private void btnContactInfo_Click(object sender, EventArgs e)
        {
   
                frm = new frmContact();
                frm.ShowDialog();
   
        }
        public string getSN() { return (Convert.ToInt32(DB.Data("select count(SN) from office").Rows[0][0].ToString()) + 1) + ""; }

        public void NewProcess()
        {
            try
            {
            txtSN.Text = getSN();
            txtCompName.Text = "";
            cbxGover.SelectedIndex = -1;
            memClassify.Text = "";
            memotxtOldBusiness.Text = "";
            memotxtNotes.Text = "";
                clbDoc.UnCheckAll();
                fbd.SelectedPath = "";
                cbxHandled.Checked = false;
                cbxNotHandled.Checked = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

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
                if (!vpOffice.Validate()) return;
                if (!dealWithUdaCheck()) return;

                //collect data
                string sn = txtSN.Text ;
                string companyName = txtCompName.Text;
                string classify = memClassify.Text;
                string gov = cbxGover.EditValue + "";
                string lastBuss = memotxtOldBusiness.Text;
                string notes = memotxtNotes.Text;
                List<int> docItems = clbDoc.CheckedIndices.ToList();
                string dealWithUda = cbxHandled.Checked ? "تم التعامل" : "لم يتم التعامل";
                //1- insert to office table
                DB.insertToDB("office", new string[] { "SN", "companyName",  "catBusiness", "oldBusiness", "attachFile", "dealWithUda", "notes", "gov", "userName" },
                    new object[] { sn, companyName, classify, lastBuss, fbd.SelectedPath, dealWithUda, notes, gov ,userInfo.userName});
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
                DB.insertToDB("reqDocOffice", new string[] { "docName", "officeID" },
               new object[] { docRecord, sn });

                //3-insert to contactInfo
                if (frm != null)
                {
                    string info = frm.txtName.Text + " , " + frm.txtMobile.Text + " , " + frm.txtEmail.Text + " , " + frm.txtSite.Text + " , " + frm.txtAddress.Text + " . ";
                    DB.insertToDB("contactInfoOffice", new string[] { "contactInfo", "officeID" },
                    new object[] { info, sn });
                    frm.Close();
                }
                else
                {
                    DB.insertToDB("contactInfoOffice", new string[] { "contactInfo", "officeID" },
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


        FolderBrowserDialog fbd;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            fbd.ShowDialog();
        }

        private void OfficeInput_Load(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();

            NewProcess();
        }
    }
}
