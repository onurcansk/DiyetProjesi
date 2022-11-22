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
            FillDailyReport(userName);
        }

        private void FillDailyReport(string userName)
        {
            lblDailyReportDay.Text = DateTime.Now.ToString("dddd");
            List<MealVm> dailyMeals = _mealManager.GetAllByExpression(x => x.CreatedDate == DateTime.Now && x.UserName == userName);
            lblDailyReportMealCount.Text = dailyMeals.Count.ToString();
            lblDailyReportFoodCount.Text = CountFoodFromMealList(dailyMeals).ToString();
            lblDailyReportTotalCalorie.Text = CalculateTotalCalorieForMeals(dailyMeals).ToString();
        }

        private double CalculateTotalCalorieForMeals(List<MealVm> meals)
        {
            double? totalCal = 0;
            foreach (var meal in meals)
            {
                foreach (var food in meal.MealDetailVm)
                {
                    totalCal += food.UnitCalorie * food.Gram;
                }
            }
            return totalCal == null ? 0 : totalCal.Value;
        }

        private int CountFoodFromMealList(List<MealVm> dailyMeals)
        {
            int count = 0;
            foreach (var meal in dailyMeals)
            {
                count += meal.MealDetailVm.Count;
            }
            return count;
        }

        private void FillLastMeal(string userName)
        {
            try
            {
                MealVm lastMeal = _mealManager.GetLastMealByUserName(userName);
                lblLastMealName.Text = lastMeal.MealType;
                lblLastMealDate.Text = lastMeal.Date.ToString();
                FillListView(lastMeal.MealDetailVm);
            }
            catch (Exception ex)
            {
                
            }
        }

        private void FillListView(List<MealDetailVm> mealDetails)
        {
            foreach (var food in mealDetails)
            {
                string[] mealDetail = { food.ProductType, food.Product, food.Gram.ToString(), (food.Gram * food.UnitCalorie).ToString() };
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
            System.Diagnostics.Process.Start("http://localhost:3000");
        }
    }
}
