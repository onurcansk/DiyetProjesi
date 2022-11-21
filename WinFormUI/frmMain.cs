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
            tssCurrentDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            tssActiveUser.Text = userLogin.UserName;
            _userVm = userLogin;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _frmMainPage = new frmMainPage(_userVm.UserName);
            {
                MdiParent = this;
            };
            _frmMainPage.Show();
            pnlNavItems.Controls.Add(_frmMainPage);

        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            pnlNavItems.Controls.Clear();
            pnlNavItems.Controls.Add(_frmMainPage);
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            if (_frmAddMeal == null)
            {
                _frmAddMeal = new(_userVm.UserName)
                {
                    MdiParent = this,
                };
                _frmAddMeal.Show();
            }
            pnlNavItems.Controls.Clear();
            pnlNavItems.Controls.Add(_frmAddMeal);
            _frmAddMeal.Dock = DockStyle.Fill;
        }

        private void btnUpdateMeal_Click(object sender, EventArgs e)
        {
            if (_frmReport == null)
            {
                _frmReport = new(_userVm.UserName)
                {
                    MdiParent = this
                };
                _frmReport.Show();
            }
            pnlNavItems.Controls.Clear();
            pnlNavItems.Controls.Add(_frmReport);
            _frmReport.Dock = DockStyle.Fill;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (_frmAccount == null)
            {
                _frmAccount = new()
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