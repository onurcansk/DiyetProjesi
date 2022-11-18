using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolver.Autofac;
using Entities.VMs.MealDetailVMs;
using Entities.VMs.MealVMs;
using Entities.VMs.UserVMs;
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
    public partial class frmMainPage : Form
    {
        IMealService _mealManager;
        public frmMainPage(string userName)
        {
            InitializeComponent();
            _mealManager = InstanceFactory.GetInstance<IMealService>();
            FillLastMeal(userName);
            FillDailyReport();
        }

        private void FillDailyReport()
        {
            lblDailyReportDay.Text = DateTime.Now.ToString("dddd");
            List<MealVm> dailyMeal = _mealManager.GetAllByExpression(x => x.CreatedDate == DateTime.Now);
            lblDailyReportMealCount.Text = dailyMeal.Count.ToString();
           
        }

        private void FillLastMeal(string userName)
        {
            MealVm lastMeal= _mealManager.GetLastMealByUserName(userName);
            lblLastMealName.Text = lastMeal.MealType;
            lblLastMealDate.Text = lastMeal.Date.ToString();
            FillListView(lastMeal.MealDetailVm);
        }
        
        private void FillListView(List<MealDetailVm> mealDetails)
        {
            foreach (var food in mealDetails)
            {
                string[] mealDetail = { food.ProductType, food.Product, food.Gram.ToString(), (food.Gram*food.UnitCalorie).ToString() };
                var newRow = new ListViewItem(mealDetail);
                lswLastFoods.Items.Add(newRow);
            }
        }
        private void llbWebPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                OpenWebPage();
            }
            catch (Exception)
            {
                MessageBox.Show("Web sayfası açılamadı");
            }
        }
        private void OpenWebPage()
        {
            llbWebPage.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.google.com.tr");
        }
    }
}
