using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using dvTechnicalOffice.UI.Modules;

namespace dvTechnicalOffice
{
    public partial class frmContractDivsInput : DevExpress.XtraEditors.XtraForm
    {
        public frmContractDivsInput()
        {
            InitializeComponent();
        }

        private void clbCats_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnRecord.PerformClick();
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            
           List<string> cats = new List<string>();
            if(clbCats.CheckedIndices.Count!=1 )
            {
                XtraMessageBox.Show("يجب ان يتم إختيار فئة واحدة");return;
            }
               for (int i = 0; i < clbCats.CheckedIndices.Count; i++)
                    {
                        cats.Add(clbCats.GetItemText(clbCats.CheckedIndices[i]));
                }
               if(ContractorInput.state==CheckState.Checked)
               {
                    ContractorInput.divInfo[ContractorInput.divName].Add(ContractorInput.className, cats);
               }
                else
                {
                    if (ContractorInput.divInfo[ContractorInput.divName].ContainsKey(ContractorInput.className))
                    {
                        ContractorInput.divInfo[ContractorInput.divName].Remove(ContractorInput.className);
                    }
                }
               
            Close();
        }
    }
}