using Business.Abstract;
using Business.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos.Product;
using Entities.VMs.ProductTypeVMs;
using Entities.VMs.ProductVMs;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        private readonly IProductTypeService _productTypeService;

        public ProductManager(IProductDal productDal, IProductTypeService productTypeService)
        {
            _productDal = productDal;
            _productTypeService = productTypeService;
        }

        public void Add(ProductCreateDTO product)
        {
            ProductTypeVm productType = _productTypeService.GetByName(product.ProductName);          
            Product existsProduct = _productDal.Get(p => p.ProductName == product.ProductName);
            if(existsProduct != null)
            {
                throw new AlreadyExistsException("Girilen ürün zaten mevcut");
            }

            Product newProduct = new Product()
            {
                ProductName = product.ProductName,
                UnitCalorie = product.UnitCalorie,
                CreatedDate = DateTime.Now,
                UpdatedDate = null,
                ProductTypeID = productType.Id,               
            };

            _productDal.Add(newProduct);
        }

        public void Delete(int id)
        {
            Product product = _productDal.Get(p => p.Id == id);
            if (product ==null)
            {
                throw new IdNotFoundException("Silinmeye çalışılan id ye ait ürün bulunamadı");
            }

            _productDal.Delete(product);
        }

        public List<ProductVm> GetAll()
        {
            List<Product> products = _productDal.GetAll();
            List<ProductVm> productVmList = new List<ProductVm>();
            foreach (Product item in products)
            {
                ProductVm productVm = new ProductVm()
                {
                    Id = item.Id,
                    ProductName=item.ProductName,
                    ProductTypeName=item.ProductType.ProductTypeName,
                    UnitCalorie= item.UnitCalorie
                };
            }

            return productVmList;
        }

        public List<ProductVm> GetAllByExpression(Expression<Func<Product, bool>> expression)
        {
            List<Product> products = _productDal.GetAll(expression);
            List<ProductVm> productVmList = new List<ProductVm>();
            foreach (Product item in products)
            {
                ProductVm productVm = new ProductVm()
                {
                    Id=item.Id,
                    ProductName = item.ProductName,
                    ProductTypeName = item.ProductType.ProductTypeName,
                    UnitCalorie = item.UnitCalorie
                };
            }

            return productVmList;
        }

        public ProductVm GetById(int id)
        {
            Product product = _productDal.Get(p => p.Id == id);
            if(product == null)
            {
                throw new IdNotFoundException("Girilen id ye ait ürün bulunamadı.");
            }

            ProductVm productVm = new ProductVm()
            {
                Id=product.Id,
                ProductName=product.ProductName,
                ProductTypeName = product.ProductType.ProductTypeName,
                UnitCalorie = product.UnitCalorie
            };

            return productVm;

        }

        public void Update(ProductUpdateDTO product)
        {
            Product updatedProduct = _productDal.Get(p=>p.Id==product.Id);

            if(updatedProduct == null)
            {
                throw new IdNotFoundException("Güncellenmek istenilen ürünün idsi bulunamadı");
            }

            if (product.ProductName != null)
                updatedProduct.ProductName = product.ProductName;

            if(product.ProductType!=null)
            {
                ProductTypeVm productType = _productTypeService.GetByName(product.ProductName);
                updatedProduct.ProductTypeID = productType.Id;
            }
            
            if(product.UnitCalorie != null)
            {
                updatedProduct.UnitCalorie = product.UnitCalorie;
            }

            _productDal.Update(updatedProduct);
        }
    }

}
