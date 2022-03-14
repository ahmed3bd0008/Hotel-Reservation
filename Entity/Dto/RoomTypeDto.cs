using System;

namespace Entity.Dto
{
    public class RoomTypeDto
    {
           public string Name { set; get; }
           public Guid Id { set; get; }   
    }
     public class AddRoomTypeDto
    {
          public string Name { set; get; }  
    }
     public class UpdateRoomTypeDto
    {
         public string Name { set; get; }
           public Guid Id { set; get; }
    }
}