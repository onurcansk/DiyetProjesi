using Base.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IMealDal : IEntityRepository<Meal>
    {
    }
}
