using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Core
{
   public class RoomRate
    {
       public decimal Price { get; set; }
       public DateTime FromDate { get; set; }
       public DateTime ToDate { get; set; }
        public Guid RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
    }
}
