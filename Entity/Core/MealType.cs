using Entity.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Core
{
 public   class MealType:EntityId
    {
        public string Name { set; get; }
        // public ICollection<MealPlane> MealPlanes{ set; get; }
        // public ICollection<MealPerPerson> MealPerPeoples{ set; get; }

    }
}
