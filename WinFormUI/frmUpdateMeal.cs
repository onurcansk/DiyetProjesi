using Business.Abstract;
using Business.DependencyResolver.Autofac;
using Entities.Concrete;
using Entities.Dtos.MealDetails;
using Entities.VMs.MealDetailVMs;
using Entities.VMs.ProductTypeVMs;
using Entities.VMs.ProductVMs;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
    public partial class frmUpdateMeal : Form
    {
        IMealDetailService _mealDetailService;
        IProductService _productService;
        IProductTypeService _productTypeService;
        MealDetailVm _mealDetail;
        List<ProductVm> products;
        List<ProductTypeVm> categories;
        public frmUpdateMeal(MealDetailVm mealDetail)
        {
            InitializeComponent();
            this._mealDetail = mealDetail;
            _mealDetailService = InstanceFactory.GetInstance<IMealDetailService>();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _productTypeService = InstanceFactory.GetInstance<IProductTypeService>();
            categories = _productTypeService.GetAll();
            products = _productService.GetAllByExpression(x => x.ProductType.ProductTypeName == mealDetail.ProductType);
            InitializeFoodData();
            FillFoodDatas(_mealDetail);
        }

        private void InitializeFoodData()
        {
            foreach (var product in products)
            {
                cmbProduct.Items.Add(product);
            }
            FillProducts(products);
        }

        private void FillFoodDatas(MealDetailVm mealDetail)
        {
            cmbCategory.SelectedValue = mealDetail.ProductType;
            cmbProduct.SelectedValue = mealDetail.Product;
            nmdGram.Value = (decimal)mealDetail.Gram;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MealDetailUpdateDto updatedMealDetail = new()
            {
                Id = _mealDetail.Id,
                MealType = cmbCategory.SelectedValue.ToString(),
                ProductName = cmbProduct.SelectedValue.ToString(),
                Gram = (double)nmdGram.Value

            };
            _mealDetailService.Update(updatedMealDetail);
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FillFoodDatas(_mealDetail);
        }

        private void cmbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            products = _productService.GetAllByExpression(x => x.ProductType.ProductTypeName == cmbCategory.SelectedText);
            FillProducts(products);
        }

        private void FillProducts(List<ProductVm> products)
        {
            cmbProduct.Items.Clear();
            foreach(var product in products)
            {
                cmbProduct.Items.Add(product);
            }
        }
    }
}
