using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class frmAdminFood : Form
    {
        public frmAdminFood()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAdminAddFood frm = new();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmAdminUpdateFood frm = new();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void tsmMealType_Click(object sender, EventArgs e)
        {
            frmAdminMealType frm = new();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void tsmCategory_Click(object sender, EventArgs e)
        {
            frmAdminCategory frm = new();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
