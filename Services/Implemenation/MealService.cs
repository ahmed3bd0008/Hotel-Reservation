using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Entity.Core;
using Entity.Dto;
using Repository.Interface;
using Services.Interface;
using Services.ResponseService;

namespace Services.Implemenation
{
    public class MealService : IMealService
    {
        private readonly IUntityOfWork _untityOfWork;
        private readonly IMapper _mapper;

        public MealService(IUntityOfWork untityOfWork,IMapper mapper )
        {
            _untityOfWork=untityOfWork;
            _mapper=mapper;
        }

        public async Task<ResponseService<int>> AddMeal(AddMealPlaneDto addMeal)
        {
            var Meal=_mapper.Map<MealPlane>(addMeal);
            await _untityOfWork.MealPlaneRepository.AddEntityAsync(Meal);
            await _untityOfWork.saveAsync();
            return new ResponseService<int>(){Data=1,Status=true,Message="success"};
        }

        public async Task<ResponseService<int>> AddMealRate(AddMealPerPersonDto addMealPerPersonDto)
        {
            var MealRate=_mapper.Map<MealPerPerson>(addMealPerPersonDto);
            if(addMealPerPersonDto.ToDate<addMealPerPersonDto.FromDate)
                return new ResponseService<int>(){Status=false,Message="From date ist grate Than to Date"};
            await _untityOfWork.MealPerPersonRepository.AddEntityAsync(MealRate);
            await _untityOfWork.saveAsync();
            return new ResponseService<int>(){Data=1,Status=true,Message="success"};
        }

        public async Task<ResponseService<int>> AddMealType(AddMealTypeDto addMealTypeDto)
        {
            try
            {
                var MealType = _mapper.Map<MealType>(addMealTypeDto);
                await _untityOfWork.MealTypeRepository.AddEntityAsync(MealType);
                await _untityOfWork.saveAsync();
                return new ResponseService<int>() { Data = 1, Status = true, Message = "success" };
            }
            catch (Exception ex)
            {
                return new ResponseService<int>() { Data = 1, Status = true, Message = ex.InnerException.Message };
            }
        }

        public async Task<ResponseService<List<MealPerPersonDto>>> GetMealRate()
        {
            var Meals=await _untityOfWork.MealPerPersonRepository.getEntityAsync(false);
            var MealsDto=_mapper.Map<List<MealPerPersonDto>>(Meals);
            return new ResponseService<List<MealPerPersonDto>>(){Data=MealsDto,Status=true};
        }

        public async Task<ResponseService<List<MealPlaneDto>>> GetMeals()
        {
            var Meals=await _untityOfWork.MealPlaneRepository.
               getEntityAsync(false);
            var MealsDto=_mapper.Map<List<MealPlaneDto>>(Meals);
            return new ResponseService<List<MealPlaneDto>>(){Data=MealsDto,Status=true};
        }

        public async Task<ResponseService<List<MealTypeDto>>> GetMealType()
        {
           var Meals=await _untityOfWork.MealTypeRepository.getEntityAsync( false);
            var MealsDto=_mapper.Map<List<MealTypeDto>>(Meals);
            return new ResponseService<List<MealTypeDto>>(){Data=MealsDto,Status=true};
        }

        public async Task<ResponseService<int>> RemoveMeal(int id)
        {
          var Meal=  await _untityOfWork.MealPlaneRepository.getEntityAsyncById(id);
          if(Meal==null)
                return  new ResponseService<int>(){Message="false"};
            _untityOfWork.MealPlaneRepository.Remove(Meal);
            return new ResponseService<int>(){Message="delete"};
        }

        public async Task<ResponseService<int>> RemoveMealRate(int id)
        {
           var MealType=  await _untityOfWork.MealTypeRepository.getEntityAsyncById(id);
          if(MealType==null)
                return  new ResponseService<int>(){Message="false"};
            _untityOfWork.MealTypeRepository.Remove(MealType);
            return new ResponseService<int>(){Message="delete"};
        }

        public async Task<ResponseService<int>> RemoveMealtype(int id)
        {
            var MealRate=  await _untityOfWork.MealPerPersonRepository.getEntityAsyncById(id);
            if(MealRate==null)
                return  new ResponseService<int>(){Message="false"};
            _untityOfWork.MealPerPersonRepository.Remove(MealRate);
            return new ResponseService<int>(){Message="delete"};
        }

        public async Task<ResponseService<int>> UpateMeal(UpdateMealPlaneDto updateMealDto)
        {
             var Meal=  await _untityOfWork.MealPlaneRepository.getEntityAsyncById(updateMealDto.Id); 
             _mapper.Map(updateMealDto,Meal);
             await  _untityOfWork.saveAsync();
             return new ResponseService<int>(){Message="true"};
        }

        public async Task<ResponseService<int>> UpateMealRate(UpdateMealPerPersonDto updateMealPerPersonDto)
        {
           

              var MealRate=   _untityOfWork.MealPerPersonRepository.getEntity(d=>d.MealTypeId==updateMealPerPersonDto.MealTypeId,false); 
             _mapper.Map(updateMealPerPersonDto,MealRate);
             await  _untityOfWork.saveAsync();
             return new ResponseService<int>(){Message="true"};
        }

        public async Task<ResponseService<int>> UpateMealType(UpdateMealTypeDto updateMealTypeDto)
        {
              var MealType=  await _untityOfWork.MealTypeRepository.getEntityAsyncById(updateMealTypeDto.Id); 
             _mapper.Map(updateMealTypeDto,MealType);
             await  _untityOfWork.saveAsync();
             return new ResponseService<int>(){Message="true"};
        }
    }
}