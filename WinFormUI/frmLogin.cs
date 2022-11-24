using Business.Abstract;
using Business.DependencyResolver.Autofac;
using Entities.Dtos.Users;
using Entities.Enums;
using Entities.VMs.UserVMs;
using Business.HelperClasses;

namespace WinFormUI
{
    public partial class frmLogin : Form
    {
        Form _frm;
        IUserService _userService;
        public frmLogin()
        {
            _userService = InstanceFactory.GetInstance<IUserService>();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserLoginDTO user = new UserLoginDTO()
                {
                    UserName = txtMail.Text,
                    Password = txtPassword.Text
                };

                UserVm userLogin = _userService.Login(user);

                if (userLogin.UserClaim == UserClaims.User)
                {
                    _frm = new frmMain();
                }
                else if (userLogin.UserClaim == UserClaims.Admin)
                {
                    _frm = new frmAdmin();
                }
                CurrentUser.UserClaim = userLogin.UserClaim;
                CurrentUser.UserName = userLogin.UserName;
                this.Hide();
                _frm.ShowDialog();
                txtPassword.Clear();
                this.Show();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _frm = new frmSignUp();
            this.Hide();
            _frm.ShowDialog();
            this.Show();
        }


    }
}
