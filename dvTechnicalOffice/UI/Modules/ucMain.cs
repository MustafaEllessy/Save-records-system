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
    public partial class ucMain : DevExpress.XtraEditors.XtraUserControl
    {
        public ucMain()
        {
            InitializeComponent();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {

        }

        public void ucMain_Load(object sender, EventArgs e)
        {  
            AdvisiorsInput advisiorsInput = new AdvisiorsInput();
            advisiorsInput.Name = "AdvisiorsInput";
            panelControl1.Controls.Add(advisiorsInput);
            ContractorInput contractorInput = new ContractorInput();
            contractorInput.Name = "ContractorInput";
            panelControl1.Controls.Add(contractorInput);
            OfficeInput officeInput = new OfficeInput();
            officeInput.Name = "OfficeInput";
            panelControl1.Controls.Add(officeInput);
            SupplierInput supplierInput = new SupplierInput();
            supplierInput.Name = "SupplierInput";
            panelControl1.Controls.Add(supplierInput);
            panelControl1.Controls["AdvisiorsInput"].Dock = DockStyle.Fill;
            panelControl1.Controls["SupplierInput"].Dock = DockStyle.Fill;
            panelControl1.Controls["ContractorInput"].Dock = DockStyle.Fill;
            panelControl1.Controls["OfficeInput"].Dock = DockStyle.Fill;
            customersTileBarItemAdvisior.PerformItemClick();
            pageNO = 1;
        }
       public  int pageNO=-1;
        private void customersTileBarItemAdvisiors_ItemClick(object sender, TileItemEventArgs e)
        {
            panelControl1.Controls["AdvisiorsInput"].BringToFront();
            panelControl1.Controls["AdvisiorsInput"].Dock = DockStyle.Fill;
            pageNO = 1;
            activateButton(1);
            btnNewProcess.PerformClick();
        }
      

        public void Save()
        {
            
        }

        public string auto()
        {
            return "";
        }
        private void activateButton(int v)
        {
            if(v==1)
            {
                customersTileBarItemImport.AppearanceItem.Normal.BackColor2 = Color.Blue;
                customersTileBarItemImport.AppearanceItem.Normal.ForeColor = Color.White;
                customersTileBarItemAdvisior.AppearanceItem.Normal.BackColor2 = Color.White;
                customersTileBarItemAdvisior.AppearanceItem.Normal.ForeColor = Color.Blue;
                customersTileBarItemConstructions.AppearanceItem.Normal.BackColor2 = Color.Blue;
                customersTileBarItemConstructions.AppearanceItem.Normal.ForeColor = Color.White;
                customersTileBarItemOffice.AppearanceItem.Normal.BackColor2 = Color.Blue;
                customersTileBarItemOffice.AppearanceItem.Normal.ForeColor = Color.White;
            }
            else if(v==2)
            {
                customersTileBarItemImport.AppearanceItem.Normal.BackColor2 = Color.Blue;
                customersTileBarItemImport.AppearanceItem.Normal.ForeColor = Color.White;
                customersTileBarItemAdvisior.AppearanceItem.Normal.BackColor2 = Color.Blue;
                customersTileBarItemAdvisior.AppearanceItem.Normal.ForeColor = Color.White;
                customersTileBarItemConstructions.AppearanceItem.Normal.BackColor2 = Color.White;
                customersTileBarItemConstructions.AppearanceItem.Normal.ForeColor = Color.Blue;
                customersTileBarItemOffice.AppearanceItem.Normal.BackColor2 = Color.Blue;
                customersTileBarItemOffice.AppearanceItem.Normal.ForeColor = Color.White;   
            }
            else if (v == 3)
            {
                customersTileBarItemImport.AppearanceItem.Normal.BackColor2 = Color.White;
                customersTileBarItemImport.AppearanceItem.Normal.ForeColor = Color.Blue;
                customersTileBarItemAdvisior.AppearanceItem.Normal.BackColor2 = Color.Blue;
                customersTileBarItemAdvisior.AppearanceItem.Normal.ForeColor = Color.White;
                customersTileBarItemConstructions.AppearanceItem.Normal.BackColor2 = Color.Blue;
                customersTileBarItemConstructions.AppearanceItem.Normal.ForeColor = Color.White;
                customersTileBarItemOffice.AppearanceItem.Normal.BackColor2 = Color.Blue;
                customersTileBarItemOffice.AppearanceItem.Normal.ForeColor = Color.White;
            }
            else if (v == 4)
            {
                customersTileBarItemImport.AppearanceItem.Normal.BackColor2 = Color.Blue;
                customersTileBarItemImport.AppearanceItem.Normal.ForeColor = Color.White;
                customersTileBarItemAdvisior.AppearanceItem.Normal.BackColor2 = Color.Blue;
                customersTileBarItemAdvisior.AppearanceItem.Normal.ForeColor = Color.White;
                customersTileBarItemConstructions.AppearanceItem.Normal.BackColor2 = Color.Blue;
                customersTileBarItemConstructions.AppearanceItem.Normal.ForeColor = Color.White;
                customersTileBarItemOffice.AppearanceItem.Normal.BackColor2 = Color.White;
                customersTileBarItemOffice.AppearanceItem.Normal.ForeColor = Color.Blue;
            }
        }

        private void customersTileBarItemImports_ItemClick(object sender, TileItemEventArgs e)
        {
            panelControl1.Controls["SupplierInput"].BringToFront();
            panelControl1.Controls["SupplierInput"].Dock = DockStyle.Fill;
            activateButton(3);
            pageNO = 3;
            btnNewProcess.PerformClick();
        }

        private void customersTileBarItemConstructions_ItemClick(object sender, TileItemEventArgs e)
        {
            panelControl1.Controls["ContractorInput"].BringToFront();
            panelControl1.Controls["ContractorInput"].Dock = DockStyle.Fill;
            pageNO = 2;
            activateButton(2);
            btnNewProcess.PerformClick();
        }

        private void customersTileBarItemOffice_ItemClick(object sender, TileItemEventArgs e)
        {
            panelControl1.Controls["OfficeInput"].BringToFront();
            panelControl1.Controls["OfficeInput"].Dock = DockStyle.Fill;
            pageNO = 4;
            activateButton(4);
            btnNewProcess.PerformClick();
        }

        private void tileBar_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customersTileBarItemAdvisiors_ItemPress(object sender, TileItemEventArgs e)
        {
            
        }

        private void btnNewRecord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btnSaveRecord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        public void btnNewProcess_Click(object sender, EventArgs e)
        {
            if (pageNO == -2)
            {
                ((SupplierInput)panelControl1.Controls["SupplierInput"]).NewProcess();
                ((AdvisiorsInput)panelControl1.Controls["AdvisiorsInput"]).NewProcess();
                ((ContractorInput)panelControl1.Controls["ContractorInput"]).NewProcess();
                ((OfficeInput)panelControl1.Controls["OfficeInput"]).NewProcess();

            }
            else  if (pageNO == 1)
            {
                ((AdvisiorsInput)panelControl1.Controls["AdvisiorsInput"]).NewProcess();
            }
            else if (pageNO == 2)
            {
                ((ContractorInput)panelControl1.Controls["ContractorInput"]).NewProcess();
            }
            else if (pageNO == 3)
            {
                ((SupplierInput)panelControl1.Controls["SupplierInput"]).NewProcess();
            }
            else if (pageNO == 4)
            {
                ((OfficeInput)panelControl1.Controls["OfficeInput"]).NewProcess();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (pageNO == 1)
            {
                ((AdvisiorsInput)panelControl1.Controls["AdvisiorsInput"]).saveProcess();
            }
            else if (pageNO == 2)
            {
                ((ContractorInput)panelControl1.Controls["ContractorInput"]).saveProcess();
            }
            else if (pageNO == 3)
            {
                ((SupplierInput)panelControl1.Controls["SupplierInput"]).saveProcess();
            }
            else if (pageNO == 4)
            {
                ((OfficeInput)panelControl1.Controls["OfficeInput"]).saveProcess();
            }
        }
    }
}
