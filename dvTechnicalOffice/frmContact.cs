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
    public partial class frmContact : DevExpress.XtraEditors.XtraForm
    {
        public frmContact()
        {
            InitializeComponent();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnRecord.PerformClick();
        }
    }
}