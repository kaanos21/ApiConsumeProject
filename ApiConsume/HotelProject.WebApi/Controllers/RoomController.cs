using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService RoomService)
        {
            _roomService = RoomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var vv = _roomService.TGetList();
            return Ok(vv);
        }
        [HttpPost]
        public IActionResult AddRoom(Room p)
        {
            _roomService.TInsert(p);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var vv = _roomService.TGetByID(id);
            _roomService.TDelete(vv);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room p)
        {
            _roomService.TUpdate(p);
            return Ok();
        }
        [HttpGet("GetById")]
        public IActionResult GetRoom(int id)
        {
            var vv = _roomService.TGetByID(id);
            return Ok(vv);
        }
    }
}
