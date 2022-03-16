using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Shared;

namespace Entity.Core
{
   public class RoomRate:EntityId
    {

       public decimal Price { get; set; }
       public DateTime FromDate { get; set; }
       public DateTime ToDate { get; set; }
        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
    }
}
