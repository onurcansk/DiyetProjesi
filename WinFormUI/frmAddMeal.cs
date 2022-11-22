﻿using Business.Abstract;
using Business.DependencyResolver.Autofac;
using Entities.Dtos.Meal;
using Entities.Dtos.MealDetails;
using Entities.VMs.MealVMs;
using Entities.VMs.ProductTypeVMs;
using Entities.VMs.ProductVMs;
using Entities.VMs.UserVMs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class frmAddMeal : Form
    {
        IMealService _mealService;
        IMealDetailService _mealDetailService;
        IProductService _productService;
        IProductTypeService _productTypeService;
        IMealTypeService _mealTypeService;
        string _activeUser;
        public frmAddMeal(string userName)
        {
            InitializeComponent();
            _mealTypeService= InstanceFactory.GetInstance<IMealTypeService>();
            _mealService = InstanceFactory.GetInstance<IMealService>();
            _mealDetailService = InstanceFactory.GetInstance<IMealDetailService>();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _productTypeService = InstanceFactory.GetInstance<IProductTypeService>();
            _activeUser = userName;

            lstMeal.SelectedValue = null;

            FillMealComboBox();
            FillCategoryComboBox();
            FillFoodComboBox();

            FillListMeal(userName);

        }

        private void FillFoodComboBox()
        {
            foreach (var food in _productService.GetAll())
            {
                cmbFood.Items.Add(food.ProductName);
            }
        }

        private void FillCategoryComboBox()
        {
            foreach (var category in _productTypeService.GetAll())
            {
                cmbMealCategory.Items.Add(category);
            }
        }

        private void FillMealComboBox()
        {
            foreach (var meal in _mealTypeService.GetAll())
            {
                cmbMealType.Items.Add(meal.MealTypeName);
            }
        }

        private void FillListMeal(string userName)
        {
            try
            {
                List<MealVm> meals = _mealService.GetAllByExpression(m => m.CreatedDate.Value.Day == DateTime.Now.Day && m.User.UserName == userName);

                lstMeal.DataSource = meals;
            }
            catch (Exception ex)
            {
                
            }
        }

        private void lstMeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            MealVm meal = (MealVm)lstMeal.SelectedItem;
            cmbMealType.SelectedValue = meal.MealType;
            FillDataGridView(meal);
        }

        private void FillDataGridView(MealVm meal)
        {
            dgvDailyReport.Rows.Clear();
            foreach (var food in meal.MealDetailVm)
            {
                dgvDailyReport.Rows.Add(food.ProductType, food.Product, null, food.Gram, food.Gram * food.UnitCalorie, food.Id);
            }
        }

        private void btnAddMealType_Click(object sender, EventArgs e)
        {
            try
            {
                MealCreateDTO newMeal = new()
                {
                    UserName = _activeUser,
                    MealTypeName = cmbMealType.SelectedItem.ToString()
                };
                _mealService.Add(newMeal);
                FillListMeal(_activeUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbProduct.Image = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMeal.SelectedItems == null)
            {
                MessageBox.Show("Lütfen ekleme yapmak istediğiniz öğünü seçiniz");
                return;
            }

            try
            {
                ProductVm product = _productService.GetAllByExpression(x => x.ProductName == cmbFood.SelectedValue).First();

                MealVm meal = (MealVm)lstMeal.SelectedItem;

                MealDetailCreateDto newMealDetail = new()
                {
                    ProductId = product.Id,
                    MealID = meal.Id,
                    Gram = (double)nmdPortion.Value
                };

                _mealDetailService.Add(newMealDetail);
                FillDataGridView(meal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDailyReport.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz yemeği seçiniz");
            }
            try
            {
                _mealDetailService.Delete(Convert.ToInt32(dgvDailyReport.SelectedRows[0].Cells[5]));
                FillDataGridView((MealVm)lstMeal.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
