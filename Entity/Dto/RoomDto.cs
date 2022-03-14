using System;

namespace Entity.Dto
{
    public class RoomDto
    {
        public Guid Id { get; set; }
         public int RoomNum { get; set; }
     
       
    }
     public class AddRoomDto
    {
         public int RoomNum { get; set; }
    }
     public class UpdateRoomDto
    {
        public Guid Id { get; set; }
         public int RoomNum { get; set; }
    }
}