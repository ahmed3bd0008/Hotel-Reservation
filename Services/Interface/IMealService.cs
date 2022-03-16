using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entity.Core;
using Entity.Dto;
using Services.ResponseService;

namespace Services.Interface
{
    public interface IMealService
    {
         Task<ResponseService <List< MealPlaneDto>>>GetMeals();
         Task <ResponseService<List< MealTypeDto>>>GetMealType();
         Task<ResponseService<List< MealPerPersonDto>>>GetMealRate();
         Task<ResponseService<int>>AddMeal(AddMealPlaneDto addMeal);
         Task<ResponseService<int>>AddMealType(AddMealTypeDto addMealTypeDto);
         Task<ResponseService<int>>AddMealRate(AddMealPerPersonDto addMealPerPersonDto);
         Task<ResponseService<int>>UpateMeal(UpdateMealPlaneDto updateMealPlaneDto);
         Task<ResponseService<int>>UpateMealType(UpdateMealTypeDto updateMealTypeDto);
         Task<ResponseService<int>>UpateMealRate(UpdateMealPerPersonDto updateMealPerPersonDto);
         Task<ResponseService<int>>RemoveMeal(int id);
         Task<ResponseService<int>>RemoveMealtype(int id);
         Task<ResponseService<int>>RemoveMealRate(int id);

    }
}