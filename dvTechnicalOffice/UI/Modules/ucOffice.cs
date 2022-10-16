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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPrinting;
using System.IO;

namespace dvTechnicalOffice.UI.Modules
{
    public partial class ucOffice : DevExpress.XtraEditors.XtraUserControl
    {

        public ucOffice()
        {
           

            InitializeComponent();
        }

        private void ucOffice_Load(object sender, EventArgs e)
        {
            DataTable dtOffice = DB.Data("SELECT office.SN as [الرقم], office.companyName as [الشركة], office.catBusiness as [التصنيف], office.oldBusiness as [الاعمال السابقة], office.attachFile as [المرفق],  office.gov as [المحافظة], contactInfoOffice.contactInfo as [معلومات الاتصال], reqDocOffice.docName as [المستندات المطلوبة], office.dealWithUda as [التعامل مع الهيئة], office.notes as [الملاحظات], office.userName as [اسم السمتخدم] FROM(office left JOIN contactInfoOffice ON office.SN = contactInfoOffice.officeID) left JOIN reqDocOffice ON office.SN = reqDocOffice.officeID ORDER BY office.SN;");
            gridControl1.DataSource = dtOffice;
            gridView1.Columns[0].Width = 50;
            gridView1.Columns[1].Width = 100;
            gridView1.Columns[2].Width = 200;
            gridView1.Columns[3].Width = 200;
            gridView1.Columns[4].Width = 100;
            gridView1.Columns[5].Width = 100;
            gridView1.Columns[6].Width = 300;
            gridView1.Columns[7].Width = 200;
            gridView1.Columns[8].Width = 200;
            gridView1.Columns[9].Width = 100;
            gridView1.Columns[10].Width = 150;

            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                gridView1.Columns[i].ColumnEdit = new RepositoryItemMemoEdit();
            }
            gridView1.Columns[4].ColumnEdit = new RepositoryItemButtonEdit();
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
