﻿using Entity.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Core
{
   public class ReservesٌRoom:EntityId
    {
        public DateTime CheckFrom { get; set; }
        public DateTime CheckTo{ get; set; }
        public int RoomId { get; set; }
        public int PersonId { get; set; }
        public Person person { get; set; }
        public Room Room { get; set; }
    }
}
