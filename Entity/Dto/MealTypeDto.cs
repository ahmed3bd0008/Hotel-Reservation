using System;

namespace Entity.Dto
{
    public class MealTypeDto
    {
           public string Name { set; get; }
           public Guid Id { set; get; }   
    }
     public class AddMealTypeDto
    {
          public string Name { set; get; }  
    }
     public class UpdateMealTypeDto
    {
         public string Name { set; get; }
           public Guid Id { set; get; }
    }
}