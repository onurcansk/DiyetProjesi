using Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MealType : IEntity
    {
        public int Id { get; set; }
        public string MealTypeName { get; set; }
    }
}
