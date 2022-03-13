using Entity.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Core
{
  public  class Person : EntityId
    {
        public string Name { get; set; }
        public PersonType personType{get;set;}
        public string Countery { get; set; }
        public string Email { get; set; }
       public ICollection<ReservesٌRoom> reserves { get; set; }

    }
}
