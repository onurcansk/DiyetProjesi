using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos.Meal;
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
            Meal meal = _mealDal.Get(m=>m.Meal)
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public MealVm Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<MealVm> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<MealVm> GetAllByExpression(Expression<Func<Meal, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(MealUpdateDTO meal)
        {
            throw new NotImplementedException();
        }
    }

}
