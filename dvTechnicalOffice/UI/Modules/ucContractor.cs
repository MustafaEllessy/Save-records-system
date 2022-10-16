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
    public partial class ucContractor : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public ucContractor()
        {
            InitializeComponent();
        }
        private void ucContractor_Load(object sender, EventArgs e)
        {
            setGrid();   
        }
        public DataTable dtContractors;
        public void setGrid()
        {
            DataTable dtContractors1 = DB.Data("SELECT contractors.SN AS الرقم, contractors.companyName AS الشركة, contractors.catBusiness AS[تصنيف العمل], contractors.gov AS المحافظة, contractors.oldBusiness AS[الأعمال السابقة], contractors.attachFile AS المرفق, contactInfoCon.contactInfo AS[معلومات الاتصال], reqDocCon.docName AS المطلوب, contractors.dealWithUda AS[التعامل مع الهيئة], contractors.notes AS ملاحظات ,contractors.userName as [اسم المستخدم]  FROM(contractors LEFT JOIN contactInfoCon ON contractors.SN = contactInfoCon.conID) LEFT JOIN reqDocCon ON contractors.SN = reqDocCon.conID ORDER BY contractors.SN;");
            dtContractors = new DataTable();
            dtContractors.Columns.Add("الرقم", typeof(int));
            dtContractors.Columns.Add("الشركة", typeof(string));
            dtContractors.Columns.Add("تصنيف الأعمال", typeof(string));
            dtContractors.Columns.Add("المحافظة", typeof(string));
            dtContractors.Columns.Add("الأعمال السابقة", typeof(string));
            dtContractors.Columns.Add("المرفقات", typeof(string));
            dtContractors.Columns.Add("معلومات الأتصال", typeof(string));
            dtContractors.Columns.Add("المستندات", typeof(string));
            dtContractors.Columns.Add("التعامل مع الهيئة", typeof(string));
            dtContractors.Columns.Add("الشعبة والتصنيف والفئات", typeof(string));
            dtContractors.Columns.Add("الملاحظات", typeof(string));
            dtContractors.Columns.Add("اسم المستخدم", typeof(string));
            gridControl1.DataSource = dtContractors;
            gridView1.Columns[0].Width = 50;
            gridView1.Columns[1].Width = 100;
            gridView1.Columns[2].Width = 200;
            gridView1.Columns[3].Width = 100;
            gridView1.Columns[4].Width = 200;
            gridView1.Columns[5].Width = 200;
            gridView1.Columns[6].Width = 200;
            gridView1.Columns[7].Width = 100;
            gridView1.Columns[8].Width = 200;
            gridView1.Columns[9].Width = 400;
            gridView1.Columns[10].Width = 100;
            gridView1.Columns[11].Width = 150;
            setDivInfo();
            for (int i = 0; i < dtContractors1.Rows.Count; i++)
            {

                int sn = Convert.ToInt32(dtContractors1.Rows[i][0].ToString());
                bool skip = false;
                for (int k = 0; k < dtContractors.Rows.Count; k++)
                {
                    if(sn==Convert.ToInt32( dtContractors.Rows[k][0].ToString()))
                    {
                        skip = true;
                        break;
                    }

                }
                if (skip) continue ;

                 object[] row = new object[] {sn,
                 dtContractors1.Rows[i][1].ToString(),
                 dtContractors1.Rows[i][2].ToString(),
                 dtContractors1.Rows[i][3].ToString(),
                 dtContractors1.Rows[i][4].ToString(),
                 dtContractors1.Rows[i][5].ToString(),
                 dtContractors1.Rows[i][6].ToString(),
                 dtContractors1.Rows[i][7].ToString(),
                 dtContractors1.Rows[i][8].ToString(),
                 "",
                 dtContractors1.Rows[i][9].ToString(),
                 dtContractors1.Rows[i][10].ToString()
           };
                string divInforman = "";
                Dictionary<string, Dictionary<string, List<string>>> divInf = divDic[sn];
                int cAll1 = 0;
                foreach (var item in divInf)
                {
                  
                    cAll1++;
                    divInforman += item.Key;
                    divInforman += "/";
                    int cAll2 = 0;
                    foreach (var item2 in item.Value)
                    {
                        cAll2++;
                        divInforman += item2.Key;
                        divInforman += ":";
                        int c = 0;
                        foreach (var item3 in item2.Value)
                        {
                            c++;
                            if (c == item2.Value.Count)
                            {
                                divInforman += item3;
                            }
                            else
                            {
                                divInforman += item3;
                                divInforman += '-';
                            }
                        }
                        if (cAll2 != item.Value.Count)
                            divInforman += '،';
                    }
                    if (cAll1 != divInf.Count)
                        divInforman += '\n';
                }
             
                row[9] = divInforman;
                dtContractors.Rows.Add(row);
            }
            gridControl1.DataSource = dtContractors;
            // gridView1.Columns[10].Width = 200;
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                gridView1.Columns[i].ColumnEdit = new RepositoryItemMemoEdit();
            }
            gridView1.Columns[5].ColumnEdit= new RepositoryItemButtonEdit();
        }

        Dictionary<int, Dictionary<string, Dictionary<string, List<string>>>> divDic;
        private void setDivInfo()
        {
            divDic = new Dictionary<int, Dictionary<string, Dictionary<string, List<string>>>>();
            DataTable dtDivsAndClasses = DB.Data("SELECT divs.divName, classes.className, cats.catName, contractors.SN FROM(divs INNER JOIN(classes INNER JOIN(cats INNER JOIN classCats ON cats.ID = classCats.catID) ON classes.ID = classCats.classID) ON divs.ID = classes.divID) INNER JOIN(contractors INNER JOIN contractDiv ON contractors.SN = contractDiv.contractID) ON divs.ID = contractDiv.divID ORDER BY contractors.SN, divs.divName, classes.className, cats.catName ;");
            for (int k = 0; k < dtDivsAndClasses.Rows.Count; k++)
            {
                int sn = Convert.ToInt32(dtDivsAndClasses.Rows[k][3].ToString());
                string dName = dtDivsAndClasses.Rows[k][0].ToString();
                string CName = dtDivsAndClasses.Rows[k][1].ToString();
                string catName = dtDivsAndClasses.Rows[k][2].ToString();
                if(divDic.ContainsKey(sn))
                {
                  if(divDic[sn].ContainsKey(dName))
                    {
                        if (divDic[sn][dName].ContainsKey(CName))
                        {
                            divDic[sn][dName][CName].Add(catName);
                        }
                        else
                        {
                            divDic[sn][dName].Add(CName,new List<string>() { catName });
                        }

                    }
                  else
                    {
                        divDic[sn].Add(dName, new Dictionary<string, List<string>>());
                        divDic[sn][dName].Add(CName, new List<string>() { catName });
                    }
                }
                else
                {
                    divDic.Add(sn, new Dictionary<string, Dictionary<string, List<string>>>());
                    divDic[sn].Add(dName, new Dictionary<string, List<string>>());
                    divDic[sn][dName].Add(CName, new List<string>() { catName });
                }
            }
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.VisibleIndex == 7 && e.Value + "" != "")
            {
                e.DisplayText = Path.GetFileNameWithoutExtension(e.Value + "");
            }
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
        public List<int> editedIndeces = new List<int>();
        private void gridView1_CustomRowCellEditForEditing_1(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if(!editedIndeces.Contains(e.RowHandle))
            editedIndeces.Add(e.RowHandle);
        }
        public List<int> deletedIndeces = new List<int>();
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
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_PrintInitialize(object sender, DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs e)
        {
            PrintingSystemBase pb = e.PrintingSystem as PrintingSystemBase;
            pb.PageSettings.Landscape = true;
        }

        private void gridView1_RowCellClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.VisibleIndex == 5 && e.CellValue != null)
            {
                if (Directory.Exists(e.CellValue + ""))
                    System.Diagnostics.Process.Start(e.CellValue + "");
            }
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
