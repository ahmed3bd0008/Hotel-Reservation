using System;

namespace Entity.Dto
{
    public class RoomRateDto
    {

         public decimal Price { get; set; }
       public DateTime FromDate { get; set; }
       public DateTime ToDate { get; set; }
        public int RoomTypeId { get; set; }
       
    }
     public class AddRoomRateDto
    {
         public decimal Price { get; set; }
       public DateTime FromDate { get; set; }
       public DateTime ToDate { get; set; }
        public int RoomTypeId { get; set; }
    }
     public class UpdateRoomRateDto
    {
        public decimal Price { get; set; }
       public DateTime FromDate { get; set; }
       public DateTime ToDate { get; set; }
        public int RoomTypeId { get; set; }
    }
}