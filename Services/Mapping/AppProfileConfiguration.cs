using AutoMapper;
using Entity.Core;
using Entity.Dto;

namespace Services.Mapping
{
    public class AppProfileConfiguration:Profile
    {
         public AppProfileConfiguration()
         {
             CreateMap<MealPlaneDto,MealPlane>().ReverseMap();
             CreateMap<MealTypeDto,MealType>().ReverseMap();
             CreateMap<MealPerPersonDto,MealPerPerson>().ReverseMap();
             CreateMap<Room,RoomDto>().ReverseMap();
             CreateMap<RoomType,RoomTypeDto>().ReverseMap();
             CreateMap<RoomRate,RoomRateDto>().ReverseMap();
         }
    }
}