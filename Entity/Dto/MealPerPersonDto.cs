using System;

namespace Entity.Dto
{
    public class MealPerPersonDto
    {
       public decimal Price { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int MealTypeId { get; set; }
    }
     public class AddMealPerPersonDto
    {
       public decimal Price { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int MealTypeId { get; set; }
    }
     public class UpdateMealPerPersonDto
    {
        public decimal Price { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int MealTypeId { get; set; }
    }
}