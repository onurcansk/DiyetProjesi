using Base.Aspects.Autofac.Validation;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Exceptions;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dtos.MealType;
using Entities.Enums;
using Entities.VMs.MealTypeVMs;
using Entities.VMs.ProductTypeVMs;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class MealTypeManager : IMealTypeService
    {
        private readonly IMealTypeDal _mealTypeDal;
        public MealTypeManager(IMealTypeDal mealTypeDal)
        {
            _mealTypeDal = mealTypeDal;
        }

        [SecuredOperation(UserClaims.Admin)]
        [ValidationAspect(typeof(ProductTypeValidator))]
        public void Add(MealTypeCreateDto mealType)
        {
            MealType newMealType = new MealType()
            {
                MealTypeName = mealType.MealTypeName
            };

            _mealTypeDal.Add(newMealType);
        }

        [SecuredOperation(UserClaims.Admin)]
        public void Delete(int id)
        {
            MealType mealType = _mealTypeDal.Get(pt => pt.Id == id);
            if (mealType == null)
            {
                throw new IdNotFoundException("Girilen Idye ait bir öğün tipi bulunamadı");
            }

            _mealTypeDal.Delete(mealType);
        }

        public List<MealTypeVm> GetAll()
        {
            List<MealType> mealTypes = _mealTypeDal.GetAll();
            List<MealTypeVm> MealTypeVmList = new List<MealTypeVm>();

            foreach (MealType item in mealTypes)
            {
                MealTypeVm productTypeVm = new MealTypeVm()
                {
                    MealTypeName = item.MealTypeName
                };
                MealTypeVmList.Add(productTypeVm);
            }

            return MealTypeVmList;
        }

        public List<MealTypeVm> GetAllByExpression(Expression<Func<MealType, bool>> expression)
        {
            List<MealType> mealTypes = _mealTypeDal.GetAll(expression);
            List<MealTypeVm> MealTypeVmList = new List<MealTypeVm>();

            foreach (MealType item in mealTypes)
            {
                MealTypeVm productTypeVm = new MealTypeVm()
                {
                    MealTypeName = item.MealTypeName
                };
                MealTypeVmList.Add(productTypeVm);
            }

            return MealTypeVmList;
        }

        public MealTypeVm GetById(int id)
        {
            MealType mealType = _mealTypeDal.Get(pt => pt.Id == id);
            if (mealType == null)
            {
                throw new IdNotFoundException("Girilen Idye ait bir öğün tipi bulunamadı");
            }

            MealTypeVm mealTypeVm = new MealTypeVm()
            {
                 MealTypeName= mealType.MealTypeName
            };

            return mealTypeVm;
        }

        [SecuredOperation(UserClaims.Admin)]
        [ValidationAspect(typeof(ProductTypeValidator))]
        public void Update(MealTypeUpdateDto mealType)
        {
            MealType mealTypeUpdated = new MealType()
            {
                Id = mealType.Id,
                MealTypeName = mealType.MealTypeName
            };

            _mealTypeDal.Update(mealTypeUpdated);
        }
    }

}
