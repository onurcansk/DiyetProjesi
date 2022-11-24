using Business.Abstract;
using Business.DependencyResolver.Autofac;
using Entities.Dtos;
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
    public partial class frmAccount : Form
    {
        IUserService _userService;
        public frmAccount(string userName)
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
            txtMail.Text = userName;        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPassword2.Text)
            {
                MessageBox.Show("Girilen şifreler birbiriyle aynı değil.");
                return;
            }
            try
            {
                UserChangePasswordDTO newUserData = new UserChangePasswordDTO()
                {
                    UserName = txtMail.Text,
                    OldPassword = txtCurrentPassword.Text,
                    NewPassword = txtPassword.Text,

                };

                _userService.ChangePassword(newUserData);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
