using Business.Abstract;
using Business.Concrete;
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
    public partial class frmAdminReport : Form
    {
        IProductService _productService;
        IMealDetailService _mealDetailService;
        IMealService _mealService;
        public frmAdminReport()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _mealDetailService = InstanceFactory.GetInstance<IMealDetailService>();
            _mealService = InstanceFactory.GetInstance<IMealService>();
            FillMeals();
            FillListView(_mealDetailService.GetTopTenProduct(), lvTotal);
        }

        private void FillMeals()
        {
            foreach (var meal in _mealService.GetAll())
            {
                cmbMealType.Items.Add(meal.MealType);
            }
            cmbMealType.SelectedIndex = 0;
        }

        private void cmbMealType_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ReportVm> meals = _mealDetailService.GetTopTenProduct(x => x.Meal.MealType == cmbMealType.SelectedItem);
            FillListView(meals, lvTotalByMeal);
        }

        private void FillListView(List<ReportVm> meals,ListView listView)
        {
            foreach (var product in meals)
            {
                string[] newProduct = { product.Key, product.Toplam.ToString() };
                var row = new ListViewItem(newProduct);
                listView.Items.Add(row);
            }
        }
    }
}
