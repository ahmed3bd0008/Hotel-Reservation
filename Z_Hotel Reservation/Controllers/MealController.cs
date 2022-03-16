using Entity.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MealController : ControllerBase
    {
        private readonly ILogger<MealController> _logger;
        private readonly IMealService _mealService;

        public MealController(ILogger<MealController> logger,
                                            IMealService mealService)
        {
            _logger = logger;
            _mealService = mealService;
        }

        [HttpGet("GetMeal")]
        public IActionResult GetMeal()
        {
            return Ok(_mealService.GetMeals());
        }
        [HttpPost("AddMeal")]
        public IActionResult addMeal(AddMealPlaneDto addMealDto)
        {
            return Ok(_mealService.AddMeal(addMealDto));
        }
        [HttpPut("updateMeal")]
        public IActionResult addMeal(UpdateMealPlaneDto updateMealDto)
        {
            return Ok(_mealService.UpateMeal(updateMealDto));
        }
        [HttpDelete("DeleteMeal/{id}")]
        public IActionResult DeleteMeal(int id)
        {
            return Ok(_mealService.RemoveMeal(id));
        }
        
        [HttpGet("GetMealType")]
        public IActionResult GetMealType()
        {
            return Ok(_mealService.GetMealType());
        }
        [HttpPost("AddMealType")]
        public IActionResult AddMealType(AddMealTypeDto addMealTypeDto)
        {
            return Ok(_mealService.AddMealType(addMealTypeDto));
        }
        [HttpPut("updateMealType")]
        public IActionResult UpadetrMealType(UpdateMealTypeDto updateMealTypeDto)
        {
            return Ok(_mealService.UpateMealType(updateMealTypeDto));
        }
        [HttpDelete("DeleteMealType/{id}")]
        public IActionResult DeleteMealType(int id)
        {
            return Ok(_mealService.RemoveMeal(id));
        }
        [HttpGet("GetMealRate")]
        public IActionResult GetMealRate()
        {
            return Ok(_mealService.GetMealType());
        }
        [HttpPost("AddMealRate")]
        public IActionResult addMealRate(AddMealPerPersonDto addMealRateDto)
        {
            return Ok(_mealService.AddMealRate(addMealRateDto));
        }
        [HttpPut("updateMealRate")]
        public IActionResult UpateMealRate(UpdateMealPerPersonDto updateMealRateDto)
        {
            return Ok(_mealService.UpateMealRate(updateMealRateDto));
        }
        [HttpDelete("DeleteMealRate/{id}")]
        public IActionResult DeleteMealRate(int id)
        {
            return Ok(_mealService.RemoveMealRate(id));
        }
    }
}
