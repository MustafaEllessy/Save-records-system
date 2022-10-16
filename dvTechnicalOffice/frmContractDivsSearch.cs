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
    public partial class frmDivAndCat : DevExpress.XtraEditors.XtraForm
    {
        public frmDivAndCat()
        {
            InitializeComponent();
        }
        public bool ok = false;
        private void btnFilter_Click(object sender, EventArgs e)
        {
            ok = true;
            Hide();
        }
    }
}