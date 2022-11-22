using Business.Abstract;
using Business.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos.Meal;
using Entities.VMs.MealDetailVMs;
using Entities.VMs.MealVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MealManager : IMealService
    {
        private readonly IMealDal _mealDal;
        private readonly IMealTypeService _mealTypeService;
        public MealManager(IMealTypeService mealTypeService, IMealDal mealDal)
        {
            _mealTypeService = mealTypeService;
            _mealDal = mealDal;
        }
        public void Add(MealCreateDTO meal)
        {
            Meal newMeal = new Meal()
            {
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UserName = meal.UserName,
                MealTypeID = _mealTypeService.GetByName(meal.MealTypeName).Id,
            };

            _mealDal.Add(newMeal);

        }

        public void Delete(int id)
        {
            Meal meal = _mealDal.Get(m => m.Id == id);
            if (meal == null) throw new IdNotFoundException("Girilen idye ait öğün bulunamadı.");

            _mealDal.Delete(meal);
        }

        public MealVm Get(int id)
        {
            Meal meal = _mealDal.Get(m => m.Id == id);
            if (meal == null) throw new IdNotFoundException("Girilen idye ait öğün bulunamadı.");

            MealVm mealVm = new MealVm()
            {

                Id = id,
                Date=meal.CreatedDate,
                MealType= meal.MealType.TypeName,
            };

            foreach (var item in meal.MealDetails)
            {
                MealDetailVm mealDetailVm = new MealDetailVm()
                {
                    Id = item.Id,
                    Gram = item.Gram,
                    UnitCalorie = item.Product.UnitCalorie,
                    ProductType = item.Product.ProductType.ProductTypeName,
                    Product = item.Product.ProductName
                };
                mealVm.MealDetailVm.Add(mealDetailVm);
            }
            return mealVm;
        }

        public List<MealVm> GetAll()
        {
            List<Meal> meals = _mealDal.GetAll();
            List<MealVm> mealVms = new List<MealVm>();
            foreach (var meal in meals)
            {
                MealVm mealVm = new MealVm()
                {
                    Date = meal.CreatedDate,
                    MealType = meal.MealType.TypeName,
                    Id = meal.Id,
                };

                foreach (var item in meal.MealDetails)
                {
                    MealDetailVm mealDetailVm = new MealDetailVm()
                    {
                        Id = item.Id,
                        Gram = item.Gram,
                        UnitCalorie = item.Product.UnitCalorie,
                        ProductType = item.Product.ProductType.ProductTypeName,
                        Product = item.Product.ProductName
                    };
                    mealVm.MealDetailVm.Add(mealDetailVm);
                }

                mealVms.Add(mealVm);
            }
           
            return mealVms;
        }

        public List<MealVm> GetAllByExpression(Expression<Func<Meal, bool>> expression)
        {
            List<Meal> meals = _mealDal.GetAll(expression);
            List<MealVm> mealVms = new List<MealVm>();
            foreach (var meal in meals)
            {
                MealVm mealVm = new MealVm()
                {
                    Date = meal.CreatedDate,
                    MealType = meal.MealType.TypeName,
                    Id=meal.Id,
                };

                foreach (var item in meal.MealDetails)
                {
                    MealDetailVm mealDetailVm = new MealDetailVm()
                    {
                        Id = item.Id,
                        Gram = item.Gram,
                        UnitCalorie = item.Product.UnitCalorie,
                        ProductType = item.Product.ProductType.ProductTypeName,
                        Product = item.Product.ProductName
                    };
                    mealVm.MealDetailVm.Add(mealDetailVm);
                }

                mealVms.Add(mealVm);
            }

            return mealVms;
        }

        public MealVm GetLastMealByUserName(string userName)
        {
           Meal meal = _mealDal.GetLastMealByUser(userName);
            if (meal == null) throw new Exception("Kullanıcının daha önce kayıtlı öğünü yok.");

            MealVm mealVm = new MealVm()
            {
                MealType = meal.MealType.TypeName,
                Date = meal.CreatedDate,
                Id=meal.Id
            };

            foreach (var item in meal.MealDetails)
            {
                MealDetailVm mealDetailVm = new MealDetailVm()
                {
                    Gram = item.Gram,
                    UnitCalorie = item.Product.UnitCalorie,
                    ProductType = item.Product.ProductType.ProductTypeName,
                    Product = item.Product.ProductName
                };
                mealVm.MealDetailVm.Add(mealDetailVm);
            }

            return mealVm;
        }

       
    }

}
