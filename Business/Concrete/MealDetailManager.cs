using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos.MealDetails;
using Entities.VMs.MealDetailVMs;
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
        public void Add(MealDetailCreateDto mealDetail)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public List<MealDetailVm> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<MealDetailVm> GetAllByExpression(Expression<Func<MealDetail, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public MealDetailVm GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<MealDetailVm> GetByProductName(string productName)
        {
            throw new NotImplementedException();
        }

        public List<MealDetailVm> GetByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public List<MealDetailVm> GetOneMeal(int mealId, DateTime date)
        {
            throw new NotImplementedException();
        }

        public void Update(MealDetailUpdateDto mealDetail)
        {
            throw new NotImplementedException();
        }
    }
}
