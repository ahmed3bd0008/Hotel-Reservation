using Entity.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Core
{
   public class RoomType:EntityId
    {
        public string Name { set; get; }
        public ICollection<Room> Rooms { get; set; }
        public ICollection<RoomRate> roomRates { get; set; }

    }
}
