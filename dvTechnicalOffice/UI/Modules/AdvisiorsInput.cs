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
    public partial class AdvisiorsInput : DevExpress.XtraEditors.XtraUserControl
    {
        public AdvisiorsInput()
        {
            InitializeComponent();
        }

        private void memotxtOldBusiness_EditValueChanged(object sender, EventArgs e)
        {

        }
     
        

        public string getSN() { return (Convert.ToInt32(DB.Data("select count(SN) from advisiors").Rows[0][0].ToString()) + 1)+""; }
        public void NewProcess()
        {
            try
            {
                txtSN.Text = getSN();
                txtCompName.Text = "";
                cbxGover.SelectedIndex = -1;
                memClassify.Text = "";
                memotxtOldBusiness.Text = "";
                txtEv.Text = "";
                clbDoc.UnCheckAll();
                memNotes.Text = "";
                fbd.SelectedPath = "";
                cbxHandled.Checked = false;
                cbxNotHandled.Checked = false;
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        
        }
   
        public void saveProcess()
        {
            try
            {
                if (!vpAdvisior.Validate()) return;
                if (!dealWithUdaCheck()) return;
                //collect data
                string sn = txtSN.Text ;
                string companyName = txtCompName.Text;
                string classify = memClassify.Text;
                string gov = cbxGover.EditValue + "";
                string lastBuss = memotxtOldBusiness.Text;
                string notes = memNotes.Text;
                List<int> docItems = clbDoc.CheckedIndices.ToList();
                string eva = txtEv.Text;
                string dealWithUda = cbxHandled.Checked ? "تم التعامل" : "لم يتم التعامل";
                //1- insert to advisiors table
                DB.insertToDB("advisiors", new string[] { "SN", "companyName", "gov", "classify", "oldBusiness", "Evaluate ", "attachFile", "dealWithUda", "notes","userName" },
                    new object[] { sn, companyName, gov, classify, lastBuss, eva, fbd.SelectedPath, dealWithUda, notes,userInfo.userName });
                string docRecord = "";
                for (int j = 0; j < docItems.Count; j++)
                {
                    string docName = clbDoc.GetItemValue(docItems[j]) + "";
                    if (j==docItems.Count-1)
                    {
                        docRecord += docName + ".";
                        break;
                    }
                  
                    docRecord += docName + " - ";
                }
                //2- insert to reqDoc table
                DB.insertToDB("reqDocAdv", new string[] { "docName", "advID" },
               new object[] { docRecord, sn });
            

                //3-insert to contactInfo
                if(frm!=null)
                {
                    string info = frm.txtName.Text + " , " + frm.txtMobile.Text + " , " + frm.txtEmail.Text + " , " + frm.txtSite.Text + " , " + frm.txtAddress.Text + " . ";
                    DB.insertToDB("contactInfoAdv", new string[] { "contactInfo", "advID" },
                    new object[] { info, sn});
                    frm.Close();
                }
                else
                {
                    DB.insertToDB("contactInfoAdv", new string[] { "contactInfo", "advID" },
                  new object[] { "", sn });
                }



                XtraMessageBox.Show("تم التسجيل بنجاح");
                NewProcess();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message); 
            }

        }

        private bool dealWithUdaCheck()
        {
          if(!cbxHandled.Checked &&!cbxNotHandled.Checked ||(cbxHandled.Checked && cbxNotHandled.Checked) )
            {
                XtraMessageBox.Show("يجب تحديد التعامل مع الهيئة");return false;
            }return true;
        }

        frmContact frm;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
                frm = new frmContact();
                frm.ShowDialog();
      

        }
        FolderBrowserDialog fbd;
     
        private void btnAtach_Click(object sender, EventArgs e)
        {
            fbd.ShowDialog();
        }

        private void txtSN_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCompName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxGover_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void memClassify_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEv_EditValueChanged(object sender, EventArgs e)
        {

        }
 
        private void AdvisiorsInput_Load(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();
            NewProcess();
        }

        private void clbDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void memNotes_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
