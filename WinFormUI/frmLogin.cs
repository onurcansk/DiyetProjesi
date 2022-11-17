using Business.Abstract;

using Business.DependencyResolver.Autofac;
using Entities.Dtos.Users;
using Entities.Enums;
using Entities.VMs.UserVMs;

using Business.Concrete;

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
    public partial class frmLogin : Form
    {
        Form _frm;
        IUserService _userService;
        public frmLogin()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
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
                    _frm = new frmMain(userLogin);
                }
                else if (userLogin.UserClaim == UserClaims.Admin)
                {
                    _frm = new frmAdmin();
                }
                this.Hide();
                _frm.ShowDialog();
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
