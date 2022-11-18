using Business.Abstract;
using Entities.Dtos.MealType;
using Entities.Dtos.ProductTypes;
using Entities.VMs.MealTypeVMs;
using Entities.VMs.ProductTypeVMs;
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
    public partial class frmAdminMealType : Form
    {
        IMealTypeService _mealTypeService;
        List<MealTypeVm> _mealTypeVms;
        public frmAdminMealType()
        {
            InitializeComponent();
        }

        private void frmAdminMealType_Load(object sender, EventArgs e)
        {
            FillListView();
        }

        private void FillListView()
        {
            _mealTypeVms = _mealTypeService.GetAll();
            lstMealType.Items.Clear();
            foreach (MealTypeVm item in _mealTypeVms)
            {
                lstMealType.Items.Add(item.MealTypeName);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MealTypeVm productTypeVm = _mealTypeService.GetByName(lstMealType.SelectedItem.ToString());
                _mealTypeService.Delete(productTypeVm.Id);
                FillListView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                MealTypeVm productTypeVm = _mealTypeService.GetByName(lstMealType.SelectedItem.ToString());
                MealTypeUpdateDto mealTypeUpdateDto = new MealTypeUpdateDto()
                {
                    Id = productTypeVm.Id,
                    MealTypeName = txtMealName.Text
                };
                _mealTypeService.Update(mealTypeUpdateDto);
                FillListView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            MealTypeCreateDto mealTypeCreateDto = new MealTypeCreateDto()
            {
                MealTypeName=txtMealName.Text,
            };

            try
            {
                _mealTypeService.Add(mealTypeCreateDto);
                FillListView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
