using Base.Aspects.Autofac.Validation;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Exceptions;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos.ProductTypes;
using Entities.Enums;
using Entities.VMs.ProductTypeVMs;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class ProductTypeManager : IProductTypeService
    {
        private readonly IProductTypeDal _productTypeDal;
        public ProductTypeManager(IProductTypeDal productTypeDal)
        {
            _productTypeDal = productTypeDal;
        }
        [SecuredOperation(UserClaims.Admin)]
        [ValidationAspect(typeof(ProductTypeValidator))]
        public void Add(ProductTypeCreateDto productType)
        {
            ProductType newProductType = new ProductType()
            {
                ProductTypeName = productType.ProductTypeName
            };

            _productTypeDal.Add(newProductType);
        }

        [SecuredOperation(UserClaims.Admin)]
        public void Delete(int id)
        {
            ProductType productType = _productTypeDal.Get(pt => pt.Id == id);
            if (productType == null)
            {
                throw new IdNotFoundException("Girilen Idye ait bir ürün tipi bulunamadı");
            }

            _productTypeDal.Delete(productType);
        }

        public ProductTypeVm Get(int id)
        {
            ProductType productType = _productTypeDal.Get(pt => pt.Id == id);
            if (productType == null)
            {
                throw new IdNotFoundException("Girilen Idye ait bir ürün tipi bulunamadı");
            }

            ProductTypeVm productTypeVm = new ProductTypeVm()
            {
                ProductTypeName = productType.ProductTypeName
            };

            return productTypeVm;
        }

        public List<ProductTypeVm> GetAll()
        {
            List<ProductType> productTypes = _productTypeDal.GetAll();
            List<ProductTypeVm> ProductTypeVmList = new List<ProductTypeVm>();

            foreach (ProductType item in productTypes)
            {
                ProductTypeVm productTypeVm = new ProductTypeVm()
                {
                    ProductTypeName = item.ProductTypeName
                };
                ProductTypeVmList.Add(productTypeVm);
            }

            return ProductTypeVmList;
        }

        public List<ProductTypeVm> GetAllByExpression(Expression<Func<ProductType, bool>> expression)
        {
            List<ProductType> productTypes = _productTypeDal.GetAll(expression);
            List<ProductTypeVm> ProductTypeVmList = new List<ProductTypeVm>();

            foreach (ProductType item in productTypes)
            {
                ProductTypeVm productTypeVm = new ProductTypeVm()
                {
                    ProductTypeName = item.ProductTypeName
                };
                ProductTypeVmList.Add(productTypeVm);
            }

            return ProductTypeVmList;
        }

        public ProductTypeVm GetByName(string name)
        {
            ProductType productType = _productTypeDal.Get(p=>p.ProductTypeName==name);
            if(productType == null)
            {
                throw new NotFoundException("Gönderilen isme ait ürün tipi bulunamadı.");
            }
            ProductTypeVm productTypeVm = new ProductTypeVm()
            {
                Id = productType.Id,
                ProductTypeName = productType.ProductTypeName
            };
            return productTypeVm;
        }

        [SecuredOperation(UserClaims.Admin)]
        [ValidationAspect(typeof(ProductTypeValidator))]
        public void Update(ProductTypeUpdateDto productType)
        {
            ProductType productTypeUpdated = new ProductType()
            {
                Id = productType.Id,
                ProductTypeName = productType.ProductTypeName
            };

            _productTypeDal.Update(productTypeUpdated);
        }
    }

}
