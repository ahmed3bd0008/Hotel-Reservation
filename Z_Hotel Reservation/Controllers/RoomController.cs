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
        public async Task<IActionResult> GetRoom()
        {
            return Ok( await _roomService.GetRooms());
        }
        [HttpPost("AddRoom")]
        public async Task<IActionResult> addRoom(AddRoomDto addRoomDto)
        {
            return Ok(await _roomService.AddRoom(addRoomDto));
        }
        [HttpPut("updateRoom")]
        public async Task<IActionResult> addRoom(UpdateRoomDto updateRoomDto)
        {
            return Ok(await _roomService.UpateRoom(updateRoomDto));
        }
        [HttpDelete("DeleteRoom/{id}")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            return Ok(await _roomService.RemoveRoom(id));
        }
        [HttpGet("GetRoomType")]
        public async Task<IActionResult> GetRoomType()
        {
            return Ok(await _roomService.GetRoomType());
        }
        [HttpPost("AddRoomType")]
        public async Task<IActionResult> addType(AddRoomTypeDto addRoomTypeDto)
        {
            return Ok(await _roomService.AddRoomType(addRoomTypeDto));
        }
        [HttpPut("updateRoomType")]
        public async Task<IActionResult> updateRoomType(UpdateRoomTypeDto updateRoomTypeDto)
        {
            return Ok(await _roomService.UpateRoomType(updateRoomTypeDto));
        }
        [HttpDelete("DeleteRoomType/{id}")]
        public async Task<IActionResult> DeleteRoomType(int id)
        {
            return Ok(await _roomService.RemoveRoom(id));
        }
        [HttpGet("GetRoomRate")]
        public async Task<IActionResult> GetRoomRate()
        {
            return Ok(await _roomService.GetRoomType());
        }
        [HttpPost("AddRoomRate")]
        public async Task<IActionResult> addRoomRate(AddRoomRateDto addRoomRateDto)
        {
            return Ok(await _roomService.AddRoomRate(addRoomRateDto));
        }
        [HttpPut("updateRoomRate")]
        public async Task<IActionResult> addRoomRate(UpdateRoomRateDto updateRoomRateDto)
        {
            return Ok(await _roomService.UpateRoomRate(updateRoomRateDto));
        }
        [HttpDelete("DeleteRoomRate/{id}")]
        public async Task<IActionResult> DeleteRoomRate(int id)
        {
            return Ok(await _roomService.RemoveRoomRate(id));
        }
    }
}
