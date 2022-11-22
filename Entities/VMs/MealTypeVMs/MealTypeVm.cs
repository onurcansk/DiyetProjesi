using Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.VMs.MealTypeVMs
{
    public class MealTypeVm:IViewModel
    {
        public int Id { get; set; }
        public string MealTypeName { get; set; }

    }
}
