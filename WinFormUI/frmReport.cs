﻿using Business.Abstract;
using Business.DependencyResolver.Autofac;
using Entities.VMs.MealDetailVMs;
using Entities.VMs.MealVMs;

namespace WinFormUI
{
    public partial class frmReport : Form
    {
        string _activeUser;
        IMealService _mealService;
        IMealDetailService _mealDetailService;
        List<MealVm> dailyMeals;
        DateTime date;
        public frmReport(string userName)
        {
            InitializeComponent();
            _activeUser = userName;
            _mealService = InstanceFactory.GetInstance<IMealService>();
            _mealDetailService = InstanceFactory.GetInstance<IMealDetailService>();
            date = dtpDay.Value;
            GetMeals();
        }

        private void GetMeals()
        {
            dailyMeals = _mealService.GetAllByExpression(x =>
                x.CreatedDate.Value.Day == date.Day
                && x.CreatedDate.Value.Month == date.Month
                && x.CreatedDate.Value.Year == date.Year
                && x.UserName == _activeUser);
            lstMealType.DataSource = dailyMeals;
            lblCalorieValue.Text = CalculateTotalCalorieForMeals(dailyMeals).ToString();
            if (lblCalorieValue.Text == "0") lblMealCalorieValue.Text = "0"; 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMealView.SelectedRows == null)
            {
                throw new Exception("Düzenlemek istediğiniz yemeği seçiniz");
            }
            try
            {
                int id = Convert.ToInt32(dgvMealView.SelectedRows[0].Cells[5].Value);
                MealDetailVm mealDetail = _mealDetailService.GetById(id);
                frmUpdateMeal _frm = new(mealDetail);
                _frm.ShowDialog();
                GetMeals();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            try
            {
                date = dtpDay.Value;
                GetMeals();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lstMealType_SelectedIndexChanged(object sender, EventArgs e)
        {
            MealVm meal = (MealVm)lstMealType.SelectedItem;
            FillDataGridView(meal);
            lblMealCalorieValue.Text = CalculateTotalCalorieForMeal(meal).ToString();
        }

        private void FillDataGridView(MealVm meal)
        {
            dgvMealView.Rows.Clear();
            if(meal != null)
            {
                List<MealDetailVm> mealDetails = meal.MealDetailVm;
                foreach (var food in mealDetails)
                {
                    dgvMealView.Rows.Add(food.ProductType, food.Product, food.Image, food.Gram, food.Gram * food.UnitCalorie, food.Id);
                }
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

        private void btnDeleteMeal_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstMealType.SelectedItem == null) throw new Exception("Silmek istediğiniz öğünü seçiniz");
                MealVm deletedMeal = lstMealType.SelectedItem as MealVm;
                _mealService.Delete(deletedMeal.Id);
                GetMeals();
                MealVm meal = (MealVm)lstMealType.SelectedItem;
                FillDataGridView(meal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = dgvMealView.SelectedRows.Count;
                if (temp == 0) throw new Exception("Lütfen silmek istediğiniz yemeği seçiniz");
                int id = Convert.ToInt32(dgvMealView.SelectedRows[0].Cells[5].Value);
                _mealDetailService.Delete(id);
                GetMeals();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
