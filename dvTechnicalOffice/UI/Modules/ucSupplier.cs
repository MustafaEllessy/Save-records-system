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
    public partial class ucSupplier : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public ucSupplier()
        {
            InitializeComponent();
        }

        private void ucSupplier_Load(object sender, EventArgs e)
        {
            DataTable dtSuppliers = DB.Data("SELECT suppliers.SN as [الرقم] , suppliers.companyName as [الشركة], suppliers.catBusiness as [تصنيف الأعمال], suppliers.oldBusiness as [الأعمال السابقة], suppliers.attachFile as [المرفق], suppliers.gov as [المحافظة], contactInfoSup.contactInfo as [معلومات الاتصال], reqDocSup.docName as [المستندات المطلوبة], suppliers.dealWithUda as [التعامل مع الهيئة], suppliers.notes as [الملاحظات], suppliers.userName as [اسم المستخدم] FROM(suppliers left JOIN contactInfoSup ON suppliers.SN = contactInfoSup.supID) left JOIN reqDocSup ON suppliers.SN = reqDocSup.supID ORDER BY suppliers.SN;");
            gridControl1.DataSource = dtSuppliers;
            gridView1.Columns[0].Width = 70;
            gridView1.Columns[1].Width = 100;
            gridView1.Columns[2].Width = 200;
            gridView1.Columns[3].Width = 200;
            gridView1.Columns[4].Width = 100;
            gridView1.Columns[5].Width = 100;
            gridView1.Columns[6].Width = 300;
            gridView1.Columns[7].Width = 100;
            gridView1.Columns[8].Width = 200;
            gridView1.Columns[9].Width = 200;
            gridView1.Columns[10].Width = 150;

            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                gridView1.Columns[i].ColumnEdit = new RepositoryItemMemoEdit();
            }
            gridView1.Columns[4].ColumnEdit = new RepositoryItemButtonEdit();
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.VisibleIndex == 7 && e.Value + "" != "")
            {
                e.DisplayText = Path.GetFileNameWithoutExtension(e.Value + "");
            }
        }

        public List<int> editedIndeces = new List<int>();
        private void gridView1_CustomRowCellEditForEditing_1(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            editedIndeces.Add(e.RowHandle);
        }
        public List<int> deletedIndeces = new List<int>();
        private void gridView1_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {

        }
        public bool canDelete = false;
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && (gridView1.SelectedRowsCount == 1) && canDelete)
            {
                gridView1.DeleteRow(gridView1.GetSelectedRows()[0]);
            }

        }

        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            deletedIndeces.Add(Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[0])));
        }
        private void openFile(string vl)
        {
            Process.Start(vl);
        }

        private void gridView1_PrintInitialize(object sender, DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs e)
        {
            PrintingSystemBase pb = e.PrintingSystem as PrintingSystemBase;
            pb.PageSettings.Landscape = true;
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.VisibleIndex == 4 && e.CellValue != null)
            {
                if (Directory.Exists(e.CellValue + ""))
                    System.Diagnostics.Process.Start(e.CellValue + "");
            }
        }
    }
}
