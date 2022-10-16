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

namespace dvTechnicalOffice
{
    public partial class frmLog : DevExpress.XtraEditors.XtraForm
    {
        public frmLog()
        {
            InitializeComponent();
        }
        DataTable dtUser;
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            userInfo.userName = txtUsername.Text;
            userInfo.password = txtPassword.Text;
            bool correct = false;
            for (int i = 0; i < dtUser.Rows.Count; i++)
            {
                if(dtUser.Rows[i][1].ToString()==userInfo.userName && dtUser.Rows[i][2].ToString() == userInfo.password)
                {
                    correct = true;
                    break;
                }
            }
            if(!correct)
            {
                XtraMessageBox.Show("اسم المستخدم او كلمة المرور خاطئة");
                txtPassword.SelectAll();
            }
            else
            {
                Hide();
              new frmTechnicalOffice().ShowDialog();
            }
            
        }

        private void frmLog_Load(object sender, EventArgs e)
        {
            dtUser = DB.Data("select * from userInfo");
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnEnter.PerformClick();
            }
        }
    }
}