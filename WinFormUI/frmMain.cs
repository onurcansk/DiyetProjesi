using Entities.VMs.UserVMs;

namespace WinFormUI
{
    public partial class frmMain : Form
    {
        frmMainPage _frmMainPage;
        frmAddMeal _frmAddMeal;
        frmReport _frmReport;
        frmAccount _frmAccount;
        UserVm _userVm;
        public frmMain(UserVm userLogin)
        {
            InitializeComponent();
            lblCurrentDate.Text = "Tarih : " + DateTime.Now.ToString("D");
            lblActiveUser.Text = "Kullanýcý : " + userLogin.UserName;
            _userVm = userLogin;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _frmMainPage = new frmMainPage(_userVm.UserName)
            {
                MdiParent = this
            };
            _frmMainPage.Show();
            pnlNavItems.Controls.Add(_frmMainPage);
            _frmMainPage.Dock = DockStyle.Fill;
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            _frmMainPage = new frmMainPage(_userVm.UserName)
            {
                MdiParent = this
            };
            _frmMainPage.Show();
            pnlNavItems.Controls.Clear();
            pnlNavItems.Controls.Add(_frmMainPage);
            _frmMainPage.Dock = DockStyle.Fill;
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            _frmAddMeal = new(_userVm.UserName)
            {
                MdiParent = this,
            };
            _frmAddMeal.Show();
            pnlNavItems.Controls.Clear();
            pnlNavItems.Controls.Add(_frmAddMeal);
            _frmAddMeal.Dock = DockStyle.Fill;
        }

        //private void btnNavigation_Click(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    switch (btn.Tag)
        //    {
        //        case 1: break;
        //        case 2: break;
        //        case 3: break;
        //        case 4: break;
        //        default:
        //            break;
        //    }
        //}

        //private void CheckOpen<T> (T frm) where T : Form,new(string ad)
        //{
        //    frm = new();
        //}

        private void btnUpdateMeal_Click(object sender, EventArgs e)
        {
            _frmReport = new(_userVm.UserName)
            {
                MdiParent = this
            };
            _frmReport.Show();
            pnlNavItems.Controls.Clear();
            pnlNavItems.Controls.Add(_frmReport);
            _frmReport.Dock = DockStyle.Fill;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (_frmAccount == null)
            {
                _frmAccount = new(_userVm.UserName)
                {
                    MdiParent = this
                };
                _frmAccount.Show();
            }
            pnlNavItems.Controls.Clear();
            pnlNavItems.Controls.Add(_frmAccount);
            _frmAccount.Dock = DockStyle.Fill;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}