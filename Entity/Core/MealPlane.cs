using Entity.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Core
{
 public   class MealPlane:EntityId
    {
        public string Name { get; set; }
        public int MealTypeId { get; set; }
        
        public MealType MealType { get; set; }
        
    }
}
