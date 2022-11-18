using Business.Abstract;
using Business.DependencyResolver.Autofac;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.VMs.MealDetailVMs;
using Entities.VMs.MealVMs;
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
    public partial class frmReport : Form
    {
        string _activeUser;
        IMealService _mealService;
        IMealDetailService _mealDetailService;
        List<MealVm> dailyMeals;
        public frmReport(string userName)
        {
            InitializeComponent();
            _activeUser = userName;
            _mealService = InstanceFactory.GetInstance<IMealService>();
            _mealDetailService = InstanceFactory.GetInstance<IMealDetailService>();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMealView.SelectedRows == null)
            {
                return;
            }
            int id = Convert.ToInt32(dgvMealView.SelectedRows[0].Cells[5].Value);
            MealDetailVm mealDetail = _mealDetailService.GetById(id);
            frmUpdateMeal _frm = new(mealDetail);
            _frm.ShowDialog();
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            DateTime reportTime = dtpDay.Value;
            dailyMeals = _mealService.GetAllByExpression(x => x.CreatedDate == reportTime && x.UserName == _activeUser);
            lstMealType.DataSource = dailyMeals;
            lblCalorieValue.Text = CalculateTotalCalorieForMeals(dailyMeals).ToString();
            
        }

        private void lstMealType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstMealType.SelectedIndex;
            MealVm meal = dailyMeals[index];
            FillDataGridView(meal);
            lblMealCalorieValue.Text = CalculateTotalCalorieForMeal(meal).ToString();
        }

        private void FillDataGridView(MealVm meal)
        {
            List<MealDetailVm> mealDetails = meal.MealDetailVm;
            foreach (var food in mealDetails)
            {
                dgvMealView.Rows.Add(food.ProductType, food.Product, null, food.Gram, food.Gram * food.UnitCalorie, food.Id);
            }
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

        private double CalculateTotalCalorieForMeal(MealVm meal)
        {
            double? totalCal = 0;
            foreach (var product in meal.MealDetailVm)
            {
                totalCal += product.Gram * product.UnitCalorie;
            }
            return totalCal == null ? 0 : totalCal.Value;
        }

    }
}
