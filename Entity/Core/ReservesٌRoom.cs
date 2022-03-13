using Entity.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Core
{
   public class ReservesٌRoom:EntityId
    {
        public Guid RoomId { get; set; }
        public Guid PersonId { get; set; }
        public Person person { get; set; }
        public Room Room { get; set; }
    }
}
