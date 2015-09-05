using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT.Account
{
    public partial class frmNewJob : Form
    {
        public frmNewJob()
        {
            InitializeComponent();
        }

        private void btnNewClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewJobLocation_Click(object sender, EventArgs e)
        {
            BIT.Account.frmNewJobLocation frm = new BIT.Account.frmNewJobLocation();
            frm.ShowDialog();
        }
    }
}
