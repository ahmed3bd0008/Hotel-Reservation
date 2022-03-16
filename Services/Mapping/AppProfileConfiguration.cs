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

            CreateMap<AddMealPlaneDto, MealPlane>().ReverseMap();
            CreateMap<AddMealTypeDto, MealType>().ReverseMap();
            CreateMap<AddMealPerPersonDto, MealPerPerson>().ReverseMap();
            CreateMap<Room, AddRoomDto>().ReverseMap();
            CreateMap<RoomType, AddRoomTypeDto>().ReverseMap();
            CreateMap<RoomRate, AddRoomRateDto>().ReverseMap();


            CreateMap<UpdateMealPlaneDto, MealPlane>().ReverseMap();
            CreateMap<UpdateMealTypeDto, MealType>().ReverseMap();
            CreateMap<UpdateMealPerPersonDto, MealPerPerson>().ReverseMap();
            CreateMap<Room, UpdateRoomDto>().ReverseMap();
            CreateMap<RoomType, UpdateRoomTypeDto>().ReverseMap();
            CreateMap<RoomRate, UpdateRoomRateDto>().ReverseMap();
        }
    }
}