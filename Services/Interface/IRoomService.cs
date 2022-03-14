using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entity.Dto;
using Services.ResponseService;

namespace Services.Interface
{
    public interface IRoomService
    {
         Task<ResponseService <List< RoomDto>>>GetRooms();
         Task <ResponseService<List< RoomTypeDto>>>GetRoomType();
         Task<ResponseService<List< RoomRateDto>>>GetRoomRate();
         Task<ResponseService<int>>AddRoom(AddRoomDto addRoom);
         Task<ResponseService<int>>AddRoomType(AddRoomTypeDto addRoomTypeDto);
         Task<ResponseService<int>>AddRoomRate(AddRoomRateDto addRoomRateDto);
         Task<ResponseService<int>>UpateRoom(UpdateRoomDto updateRoomDto);
         Task<ResponseService<int>>UpateRoomType(UpdateRoomTypeDto updateRoomTypeDto);
         Task<ResponseService<int>>UpateRoomRate(UpdateRoomRateDto updateRoomRateDto);
         Task<ResponseService<int>>RemoveRoom(Guid id);
         Task<ResponseService<int>>RemoveRoomtype(Guid id);
         Task<ResponseService<int>>RemoveRoomRate(Guid id);

    }
}