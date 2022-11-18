using Business.Abstract;
using Business.DependencyResolver.Autofac;
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
    public partial class frmAddMeal : Form
    {
        IMealService _mealService;
        IMealDetailService _mealDetailService;
        public frmAddMeal()
        {
            InitializeComponent();
            _mealService = InstanceFactory.GetInstance<IMealService>();
            _mealDetailService = InstanceFactory.GetInstance<IMealDetailService>();
            FillListMeal();
        }

        private void FillListMeal()
        {
            List<MealVm> meals = _mealService.GetAllByExpression(m => m.CreatedDate ==  DateTime.Now);
            lstMeal.DataSource = meals;
        }
    }
}
