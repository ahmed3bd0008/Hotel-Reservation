using System;
using Entity.Shared;

namespace Entity.Dto
{
    public class PersonReservationReservationDto
    {
       public int Id { get; set; }
       public string Name { get; set; }
        public PersonType personType{get;set;}
        public string Countery { get; set; }
        public string Email { get; set; }  
        public  int RoomNum { get; set; }
        public string MealPlaneName { get; set; }
    }
     public class AddPersonReservationDto
    {
          public string Name { set; get; }  
    }
     public class UpdatePersonReservationDto
    {
         public string Name { set; get; }
           public int Id { set; get; }
    }
}