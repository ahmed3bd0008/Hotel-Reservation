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
        public async Task< IActionResult >GetMeal()
        {
            return Ok(await _mealService.GetMeals());
        }
        [HttpPost("AddMeal")]
        public async Task< IActionResult> addMeal(AddMealPlaneDto addMealDto)
        {
            return Ok(await _mealService.AddMeal(addMealDto));
        }
        [HttpPut("updateMeal")]
        public async Task< IActionResult> addMeal(UpdateMealPlaneDto updateMealDto)
        {
            return Ok(await _mealService.UpateMeal(updateMealDto));
        }
        [HttpDelete("DeleteMeal/{id}")]
        public async Task< IActionResult> DeleteMeal(int id)
        {
            return Ok(await _mealService.RemoveMeal(id));
        }
        
        [HttpGet("GetMealType")]
        public async Task< IActionResult> GetMealType()
        {
            return Ok(await _mealService.GetMealType());
        }
        [HttpPost("AddMealType")]
        public async Task< IActionResult> AddMealType(AddMealTypeDto addMealTypeDto)
        {
            return Ok(await _mealService.AddMealType(addMealTypeDto));
        }
        [HttpPut("updateMealType")]
        public async Task< IActionResult> UpadetrMealType(UpdateMealTypeDto updateMealTypeDto)
        {
            return Ok(await _mealService.UpateMealType(updateMealTypeDto));
        }
        [HttpDelete("DeleteMealType/{id}")]
        public async Task< IActionResult >DeleteMealType(int id)
        {
            return Ok(await _mealService.RemoveMeal(id));
        }
        [HttpGet("GetMealRate")]
        public async Task< IActionResult> GetMealRate()
        {
            return Ok(await _mealService.GetMealType());
        }
        [HttpPost("AddMealRate")]
        public async Task< IActionResult> addMealRate(AddMealPerPersonDto addMealRateDto)
        {
            return Ok(await _mealService.AddMealRate(addMealRateDto));
        }
        [HttpPut("updateMealRate")]
        public async Task< IActionResult >UpateMealRate(UpdateMealPerPersonDto updateMealRateDto)
        {
            return Ok ( await _mealService.UpateMealRate(updateMealRateDto));
        }
        [HttpDelete("DeleteMealRate/{id}")]
        public async Task< IActionResult> DeleteMealRate(int id)
        {
            return Ok(await _mealService.RemoveMealRate(id));
        }
    }
}
