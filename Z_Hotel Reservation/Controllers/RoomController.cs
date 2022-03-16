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
    public class RoomController : ControllerBase
    {
         private readonly ILogger<RoomController> _logger;
         private readonly IRoomService _roomService;

        public RoomController(ILogger<RoomController> logger,
                                            IRoomService roomService) 
        {
            _logger = logger;
            _roomService = roomService;
        }

        [HttpGet("GetRoom")]
        public IActionResult GetRoom()
        {
            return Ok(_roomService.GetRooms());
        }
        [HttpPost("AddRoom")]
        public IActionResult addRoom(AddRoomDto addRoomDto)
        {
            return Ok(_roomService.AddRoom(addRoomDto));
        }
        [HttpPut("updateRoom")]
        public IActionResult addRoom(UpdateRoomDto updateRoomDto)
        {
            return Ok(_roomService.UpateRoom(updateRoomDto));
        }
        [HttpDelete("DeleteRoom/{id}")]
        public IActionResult DeleteRoom(int id)
        {
            return Ok(_roomService.RemoveRoom(id));
        }
        [HttpGet("GetRoomType")]
        public IActionResult GetRoomType()
        {
            return Ok(_roomService.GetRoomType());
        }
        [HttpPost("AddRoomType")]
        public IActionResult addType(AddRoomTypeDto addRoomTypeDto)
        {
            return Ok(_roomService.AddRoomType(addRoomTypeDto));
        }
        [HttpPut("updateRoomType")]
        public IActionResult updateRoomType(UpdateRoomTypeDto updateRoomTypeDto)
        {
            return Ok(_roomService.UpateRoomType(updateRoomTypeDto));
        }
        [HttpDelete("DeleteRoomType/{id}")]
        public IActionResult DeleteRoomType(int id)
        {
            return Ok(_roomService.RemoveRoom(id));
        }
        [HttpGet("GetRoomRate")]
        public IActionResult GetRoomRate()
        {
            return Ok(_roomService.GetRoomType());
        }
        [HttpPost("AddRoomRate")]
        public IActionResult addRoomRate(AddRoomRateDto addRoomRateDto)
        {
            return Ok(_roomService.AddRoomRate(addRoomRateDto));
        }
        [HttpPut("updateRoomRate")]
        public IActionResult addRoomRate(UpdateRoomRateDto updateRoomRateDto)
        {
            return Ok(_roomService.UpateRoomRate(updateRoomRateDto));
        }
        [HttpDelete("DeleteRoomRate/{id}")]
        public IActionResult DeleteRoomRate(int id)
        {
            return Ok(_roomService.RemoveRoomRate(id));
        }
    }
}
