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
    public partial class frmAdmin : Form
    {
        frmAdminFood _frmAdminFood;
        frmAdminReport _frmAdminReport;
        public frmAdmin()
        {
            InitializeComponent();
        }
        private void btnCRUD_Click(object sender, EventArgs e)
        {
            if (_frmAdminFood == null)
            {
                _frmAdminFood = new()
                {
                    MdiParent = this
                };
                _frmAdminFood.Show();
            }
            pnlMain.Controls.Add(_frmAdminFood);
            _frmAdminFood.Dock = DockStyle.Fill;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (_frmAdminReport == null)
            {
                _frmAdminReport = new()
                {
                    MdiParent = this
                };
                _frmAdminReport.Show();
            }
            pnlMain.Controls.Add(_frmAdminFood);
            _frmAdminReport.Dock = DockStyle.Fill;
        }
    }
}
