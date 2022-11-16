using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.MealDetails
{
    public class MealDetailCreateDto
    {
        public double Gram { get; set; }
        public string MealName { get; set; }
        public string ProductName { get; set; }
        public User User { get; set; }
        public string UserName { get; set; }
        public DateTime MealDate { get; set; }

    }
}
