using System;
using System.Collections.Generic;
using Entity.Shared;

namespace Entity.Core
{
    public class Room : EntityId
    {
        public int RoomNum { get; set; }
        public Guid RoomTypeId { set; get; }
        public RoomType RoomType { get; set; }

        public ICollection<ReservesٌRoom> reserves { get; set; }
    }
}