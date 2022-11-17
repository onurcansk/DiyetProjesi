using Business.Abstract;
using Business.DependencyResolver.Autofac;
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
        public frmAccount()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    UserChangePasswordDto newUserData = new() { 
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }
    }
}
