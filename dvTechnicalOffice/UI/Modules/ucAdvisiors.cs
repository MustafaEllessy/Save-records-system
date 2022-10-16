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
using System.Diagnostics;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPrinting;

namespace dvTechnicalOffice.UI.Modules
{
    public partial class ucAdvisiors : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public ucAdvisiors()
        {
            InitializeComponent();
        }
       
        private void ucContractor_Load(object sender, EventArgs e)
        {
            DataTable dtAdvisiors =  DB.Data("SELECT  advisiors.SN as [الرقم], advisiors.companyName as [الشركة], advisiors.gov as [المحافظة], advisiors.classify as [التصنيف],advisiors.oldBusiness as [أعمال سابقة], advisiors.Evaluate as [التقييم], advisiors.attachFile as [المرفق],  contactInfoAdv.contactInfo as [معلومات الاتصال],  reqDocAdv.docName as [المستندات المطلوبة], advisiors.dealWithUda as [التعامل مع الهيئة], advisiors.notes as [ملاحظات],advisiors.userName as [اسم المستخدم] FROM(advisiors left JOIN contactInfoAdv ON advisiors.SN = contactInfoAdv.advID) left JOIN reqDocAdv ON advisiors.SN = reqDocAdv.advID ORDER BY advisiors.SN;");

            gridControl1.DataSource = dtAdvisiors;
            gridView1.Columns[0].Width = 50;
            gridView1.Columns[1].Width = 100;
            gridView1.Columns[2].Width = 200;
            gridView1.Columns[3].Width = 200;
            gridView1.Columns[4].Width = 100;
            gridView1.Columns[5].Width = 50;
            gridView1.Columns[6].Width = 100;
            gridView1.Columns[7].Width = 300;
            gridView1.Columns[8].Width = 200;
            gridView1.Columns[9].Width = 200;
            gridView1.Columns[10].Width = 100;
            gridView1.Columns[11].Width = 150;

            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                gridView1.Columns[i].ColumnEdit = new RepositoryItemMemoEdit();
                    
            }
            gridView1.Columns[6].ColumnEdit = new RepositoryItemButtonEdit();
        }

        private void gridView1_CustomDrawViewCaption(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {

        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if(e.Column.VisibleIndex==7 && e.Value+""!="")
            {
                e.DisplayText = Path.GetFileNameWithoutExtension(e.Value + "");
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.VisibleIndex == 7 && e.CellValue + "" != "")
                    openFile(e.CellValue + "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void openFile(string vl)
        {
            Process.Start(vl);
        }

        public  List<int> editedIndeces=new List<int>();
        private void gridView1_CustomRowCellEditForEditing_1(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            editedIndeces.Add(e.RowHandle);
        }
        public  List<int> deletedIndeces = new List<int>();
        private void gridView1_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
                                                                                                                                                                                                                                                                                                                    
        }
        public bool canDelete = false;
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete &&(gridView1.SelectedRowsCount==1) &&canDelete )
            {
                gridView1.DeleteRow(gridView1.GetSelectedRows()[0]);
            }

        }

        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            deletedIndeces.Add(Convert.ToInt32( gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[0])));
        }

        private void gridView1_PrintInitialize(object sender, DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs e)
        {
            PrintingSystemBase pb = e.PrintingSystem as PrintingSystemBase;
            pb.PageSettings.Landscape = true;
        }

        private void gridView1_RowCellClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if(e.Column.VisibleIndex==6&&e.CellValue!= null)
            {
                if (Directory.Exists(e.CellValue + ""))
                    System.Diagnostics.Process.Start(e.CellValue + "");
            }
        }
    }
}
