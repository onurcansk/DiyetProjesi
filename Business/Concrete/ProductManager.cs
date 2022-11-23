using Base.Aspects.Autofac.Validation;
using Business.Abstract;
using Business.Exceptions;
using Business.ValidationRules.FluentValidation;
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
        [ValidationAspect(typeof(ProductCreateValidator))]
        public void Add(ProductCreateDTO product)
        {
            var getProductTuple = _productDal.Get(p => p.ProductName == product.ProductName);
            ProductTypeVm productType = _productTypeService.GetByName(product.ProductName);          
            Product existsProduct = getProductTuple.Item1;
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
                Image = product.Image,
            };

            getProductTuple.Item2.Dispose();
            _productDal.Add(newProduct);
        }

        public void Delete(int id)
        {
            var getProductTuple = _productDal.Get(p => p.Id == id);
            Product product = getProductTuple.Item1;
            if (product ==null)
            {
                throw new IdNotFoundException("Silinmeye çalışılan id ye ait ürün bulunamadı");
            }

            getProductTuple.Item2.Dispose();
            _productDal.Delete(product);
        }

        public List<ProductVm> GetAll()
        {
            var getAllTuple = _productDal.GetAll();
            List<Product> products = getAllTuple.Item1;
            List<ProductVm> productVmList = new List<ProductVm>();
            foreach (Product item in products)
            {
                ProductVm productVm = new ProductVm()
                {
                    Id = item.Id,
                    ProductName=item.ProductName,
                    ProductTypeName=item.ProductType.ProductTypeName,
                    UnitCalorie= item.UnitCalorie,
                    Image = item.Image,
                };
                productVmList.Add(productVm);
            }

            getAllTuple.Item2.Dispose();
            return productVmList;
        }

        public List<ProductVm> GetAllByExpression(Expression<Func<Product, bool>> expression)
        {
            var getAllTuple = _productDal.GetAll(expression);
            List<Product> products = getAllTuple.Item1;
            List<ProductVm> productVmList = new List<ProductVm>();
            foreach (Product item in products)
            {
                ProductVm productVm = new ProductVm()
                {
                    Id=item.Id,
                    ProductName = item.ProductName,
                    ProductTypeName = item.ProductType.ProductTypeName,
                    UnitCalorie = item.UnitCalorie,
                    Image = item.Image,
                };
                productVmList.Add(productVm);
            }

            getAllTuple.Item2.Dispose();
            return productVmList;
        }

        public ProductVm GetById(int id)
        {
            var getProductTuple = _productDal.Get(p => p.Id == id);
            Product product = getProductTuple.Item1;
            if (product == null)
            {
                throw new IdNotFoundException("Girilen id ye ait ürün bulunamadı.");
            }

            ProductVm productVm = new ProductVm()
            {
                Id=product.Id,
                ProductName=product.ProductName,
                ProductTypeName = product.ProductType.ProductTypeName,
                UnitCalorie = product.UnitCalorie,
                Image = product.Image,
            };

            getProductTuple.Item2.Dispose();
            return productVm;

        }

        public ProductVm GetByName(string name)
        {
            var getProductTuple = _productDal.Get(p => p.ProductName == name);
            Product product = getProductTuple.Item1;
            if (product == null)
            {
                throw new IdNotFoundException("Girilen id ye ait ürün bulunamadı.");
            }

            ProductVm productVm = new ProductVm()
            {
                Id = product.Id,
                ProductName = product.ProductName,
                ProductTypeName = product.ProductType.ProductTypeName,
                UnitCalorie = product.UnitCalorie,
                Image = product.Image
            };

            getProductTuple.Item2.Dispose();
            return productVm;
        }
        [ValidationAspect(typeof(ProductUpdateValidator))]
        public void Update(ProductUpdateDTO product)
        {
            var getProductTuple = _productDal.Get(p => p.Id == product.Id);
            Product updatedProduct = getProductTuple.Item1;

            if (updatedProduct == null)
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

            getProductTuple.Item2.Dispose();
            _productDal.Update(updatedProduct);
        }
    }

}
