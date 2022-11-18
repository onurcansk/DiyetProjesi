using Business.Abstract;
using Business.DependencyResolver.Autofac;
using Entities.Dtos.ProductTypes;
using Entities.VMs.ProductTypeVMs;
using Entities.VMs.ProductVMs;
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
    public partial class frmAdminCategory : Form
    {
        IProductTypeService _productTypeService;
        List<ProductTypeVm> _productTypeVm;
        public frmAdminCategory()
        {
            InitializeComponent();
            _productTypeService = InstanceFactory.GetInstance<IProductTypeService>();
        }

        private void frmAdminCategory_Load(object sender, EventArgs e)
        {
            FillListView();
        }

        private void FillListView()
        {
            _productTypeVm = _productTypeService.GetAll();
            lstCategory.Items.Clear();
            foreach (ProductTypeVm vm in _productTypeVm)
            {
                lstCategory.Items.Add(vm.ProductTypeName);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ProductTypeVm productTypeVm = _productTypeService.GetByName(lstCategory.SelectedItem.ToString());
                _productTypeService.Delete(productTypeVm.Id);
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
                ProductTypeVm productTypeVm = _productTypeService.GetByName(lstCategory.SelectedItem.ToString());
                ProductTypeUpdateDto productTypeUpdateDto = new ProductTypeUpdateDto()
                {
                    Id = productTypeVm.Id,
                    ProductTypeName= txtMealName.Text
                };
                _productTypeService.Update(productTypeUpdateDto);
                FillListView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ProductTypeCreateDto productTypeCreateDto = new ProductTypeCreateDto()
            {
                ProductTypeName = txtMealName.Text
            };

            try
            {
                _productTypeService.Add(productTypeCreateDto);
                FillListView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
