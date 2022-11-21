using Business.Abstract;
using Business.Exceptions;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos.MealDetails;
using Entities.VMs.MealDetailVMs;
using Entities.VMs.ProductVMs;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MealDetailManager : IMealDetailService
    {
        IMealDetailDal _mealDetailDal;
        IMealTypeService _mealTypeService;
        IProductService _productService;
        public MealDetailManager(IMealDetailDal mealDetailDal, IMealTypeService mealTypeService, IProductService productService)
        {
            _mealDetailDal = mealDetailDal;
            _mealTypeService = mealTypeService;
            _productService = productService;
        }
        public void Add(MealDetailCreateDto mealDetail)
        {

            MealDetail newMealDetail = new MealDetail()
            {
                Gram = mealDetail.Gram,
                MealID = mealDetail.MealID,
                ProductId = mealDetail.ProductId,
            };

            _mealDetailDal.Add(newMealDetail);
        }

        public void Delete(int id)
        {
            MealDetail deleteMealDetail = _mealDetailDal.Get(m => m.Id == id);

            if (deleteMealDetail == null)
            {
                throw new IdNotFoundException("Gönderilen id ye ait meal detail bulunamadı.");
            }
            _mealDetailDal.Delete(deleteMealDetail);
        }

        public void DeleteRange(List<int> ids)
        {
            foreach (var item in ids)
            {
                MealDetail deleteMealDetail = _mealDetailDal.Get(m => m.Id == item);
                _mealDetailDal.Delete(deleteMealDetail);
            }
        }

        public List<MealDetailVm> GetAll()
        {
            List<MealDetail> mealDetails = _mealDetailDal.GetAll();
            List<MealDetailVm> mealDetailVms = new List<MealDetailVm>();
            foreach (var item in mealDetails)
            {
                MealDetailVm mealDetailVm = new MealDetailVm()
                {
                    Gram = item.Gram,
                    MealType = item.Meal.MealType.TypeName,
                    Id = item.Id,
                    Product = item.Product.ProductName,
                    UnitCalorie = item.Product.UnitCalorie,
                    Image = item.Product.Image
                };
                mealDetailVms.Add(mealDetailVm);
            }

            return mealDetailVms;
        }

        public List<MealDetailVm> GetAllByExpression(Expression<Func<MealDetail, bool>> expression)
        {
            List<MealDetail> mealDetails = _mealDetailDal.GetAll(expression);
            List<MealDetailVm> mealDetailVms = new List<MealDetailVm>();
            foreach (var item in mealDetails)
            {
                MealDetailVm mealDetailVm = new MealDetailVm()
                {
                    Gram = item.Gram,
                    MealType = item.Meal.MealType.TypeName,
                    Id = item.Id,
                    Product = item.Product.ProductName,
                    UnitCalorie = item.Product.UnitCalorie,
                    Image = item.Product.Image
                };
                mealDetailVms.Add(mealDetailVm);
            }

            return mealDetailVms;
        }

        public MealDetailVm GetById(int id)
        {
            MealDetail mealDetail = _mealDetailDal.Get(md => md.Id == id);
            if (mealDetail == null)
            {
                throw new IdNotFoundException("Gönderilen idye ait öğün detayı bulunamadı.");
            }

            MealDetailVm mealDetailVm = new MealDetailVm()
            {
                Id = mealDetail.Id,
                Gram = mealDetail.Gram,
                MealType = mealDetail.Meal.MealType.TypeName,
                Product = mealDetail.Product.ProductName,
                UnitCalorie = mealDetail.Product.UnitCalorie,
                Image = mealDetail.Product.Image
            };

            return mealDetailVm;
        }

        public List<MealDetailVm> GetByProductName(string productName)
        {
            List<MealDetail> mealDetails = _mealDetailDal.GetAll(md => md.Product.ProductName == productName);
            List<MealDetailVm> mealDetailVms = new List<MealDetailVm>();
            foreach (var item in mealDetails)
            {
                MealDetailVm mealDetailVm = new MealDetailVm()
                {
                    Gram = item.Gram,
                    MealType = item.Meal.MealType.TypeName,
                    Id = item.Id,
                    Product = item.Product.ProductName,
                    UnitCalorie = item.Product.UnitCalorie,
                    Image = item.Product.Image
                };
                mealDetailVms.Add(mealDetailVm);
            }

            return mealDetailVms;
        }

        public void Update(MealDetailUpdateDto mealDetail)
        {
            MealDetail updatedMealDetail = _mealDetailDal.Get(md => md.Id == mealDetail.Id);
            if (mealDetail.Gram != null && mealDetail.Gram != updatedMealDetail.Gram) updatedMealDetail.Gram = mealDetail.Gram;
            if (updatedMealDetail.Product.ProductName == mealDetail.ProductName)
            {
                ProductVm product = _productService.GetByName(mealDetail.ProductName);
                updatedMealDetail.ProductId = product.Id;
            }

            _mealDetailDal.Update(updatedMealDetail);
        }

        public List<ReportVm> GetTopTenProduct(Expression<Func<MealDetail, bool>> expression = null)
        {
            return (List<ReportVm>)_mealDetailDal.GetAll(expression).GroupBy(x => x.Product.ProductName).Select(md => new ReportVm { Key = md.Key, Toplam = md.Count() });

        }
    }

    public class ReportVm
    {
        public string Key { get; set; }
        public int Toplam { get; set; }
    }
}
