using System;

namespace Entity.Dto
{
    public class MealPlaneDto
    {
           public string Name { get; set; }
           public Guid Id { set; get; }   
    }
     public class AddMealPlaneDto
    {
          public string Name { get; set; } 
    }
     public class UpdateMealPlaneDto
    {
          public string Name { get; set; }
           public Guid Id { set; get; }  
    }
}