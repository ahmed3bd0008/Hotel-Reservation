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
    public class RoomService : IRoomService
    {
        private readonly IUntityOfWork _untityOfWork;
        private readonly IMapper _mapper;

        public RoomService(IUntityOfWork untityOfWork,IMapper mapper )
        {
            _untityOfWork=untityOfWork;
            _mapper=mapper;
        }

        public async Task<ResponseService<int>> AddRoom(AddRoomDto addRoom)
        {
            var room=_mapper.Map<Room>(addRoom);
            await _untityOfWork.roomRepository.AddEntityAsync(room);
            await _untityOfWork.saveAsync();
            return new ResponseService<int>(){Data=1,Status=true,Message="success"};
        }

        public async Task<ResponseService<int>> AddRoomRate(AddRoomRateDto addRoomRateDto)
        {
            var roomRate=_mapper.Map<RoomRate>(addRoomRateDto);
            if(addRoomRateDto.ToDate<addRoomRateDto.FromDate)
                return new ResponseService<int>(){Status=false,Message="From date ist grate Than to Date"};
            await _untityOfWork.roomRateRepository.AddEntityAsync(roomRate);
            await _untityOfWork.saveAsync();
            return new ResponseService<int>(){Data=1,Status=true,Message="success"};
        }

        public async Task<ResponseService<int>> AddRoomType(AddRoomTypeDto addRoomTypeDto)
        {
            var roomType=_mapper.Map<RoomType>(addRoomTypeDto);
            await _untityOfWork.roomTypeRepository.AddEntityAsync(roomType);
            await _untityOfWork.saveAsync();
            return new ResponseService<int>(){Data=1,Status=true,Message="success"};
        }

        public async Task<ResponseService<List<RoomRateDto>>> GetRoomRate()
        {
            var Rooms=await _untityOfWork.roomRateRepository.getEntityAsync(false);
            var RoomsDto=_mapper.Map<List<RoomRateDto>>(Rooms);
            return new ResponseService<List<RoomRateDto>>(){Data=RoomsDto,Status=true};
        }

        public async Task<ResponseService<List<RoomDto>>> GetRooms()
        {
            var Rooms= _untityOfWork.roomRepository.
               getEntity(d=>!d.reserves.Any(f=>f.CheckTo>=DateTime.Now),false);
            var RoomsDto=_mapper.Map<List<RoomDto>>(Rooms);
            return new ResponseService<List<RoomDto>>(){Data=RoomsDto,Status=true};
        }

        public async Task<ResponseService<List<RoomTypeDto>>> GetRoomType()
        {
           var Rooms=await _untityOfWork.roomTypeRepository.getEntityAsync( false);
            var RoomsDto=_mapper.Map<List<RoomTypeDto>>(Rooms);
            return new ResponseService<List<RoomTypeDto>>(){Data=RoomsDto,Status=true};
        }

        public async Task<ResponseService<int>> RemoveRoom(Guid id)
        {
          var Room=  await _untityOfWork.roomRepository.getEntityAsyncById(id);
          if(Room==null)
                return  new ResponseService<int>(){Message="false"};
            _untityOfWork.roomRepository.Remove(Room);
            return new ResponseService<int>(){Message="delete"};
        }

        public async Task<ResponseService<int>> RemoveRoomRate(Guid id)
        {
           var RoomType=  await _untityOfWork.roomTypeRepository.getEntityAsyncById(id);
          if(RoomType==null)
                return  new ResponseService<int>(){Message="false"};
            _untityOfWork.roomTypeRepository.Remove(RoomType);
            return new ResponseService<int>(){Message="delete"};
        }

        public async Task<ResponseService<int>> RemoveRoomtype(Guid id)
        {
            var RoomRate=  await _untityOfWork.roomRateRepository.getEntityAsyncById(id);
            if(RoomRate==null)
                return  new ResponseService<int>(){Message="false"};
            _untityOfWork.roomRateRepository.Remove(RoomRate);
            return new ResponseService<int>(){Message="delete"};
        }

        public async Task<ResponseService<int>> UpateRoom(UpdateRoomDto updateRoomDto)
        {
             var Room=  await _untityOfWork.roomRepository.getEntityAsyncById(updateRoomDto.Id); 
             _mapper.Map(updateRoomDto,Room);
             await  _untityOfWork.saveAsync();
             return new ResponseService<int>(){Message="true"};
        }

        public async Task<ResponseService<int>> UpateRoomRate(UpdateRoomRateDto updateRoomRateDto)
        {
           

              var RoomRate=   _untityOfWork.roomRateRepository.getEntity(d=>d.RoomTypeId==updateRoomRateDto.RoomTypeId,false); 
             _mapper.Map(updateRoomRateDto,RoomRate);
             await  _untityOfWork.saveAsync();
             return new ResponseService<int>(){Message="true"};
        }

        public async Task<ResponseService<int>> UpateRoomType(UpdateRoomTypeDto updateRoomTypeDto)
        {
              var RoomType=  await _untityOfWork.roomTypeRepository.getEntityAsyncById(updateRoomTypeDto.Id); 
             _mapper.Map(updateRoomTypeDto,RoomType);
             await  _untityOfWork.saveAsync();
             return new ResponseService<int>(){Message="true"};
        }
    }
}