using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _GuestService;

        public GuestController(IGuestService GuestService)
        {
            _GuestService = GuestService;
        }

        [HttpGet]
        public IActionResult GuestList()
        {
            var vv = _GuestService.TGetList();
            return Ok(vv);
        }
        [HttpPost]
        public IActionResult AddGuest(Guest p)
        {
            _GuestService.TInsert(p);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteGuest(int id)
        {
            var vv = _GuestService.TGetByID(id);
            _GuestService.TDelete(vv);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateGuest(Guest p)
        {
            _GuestService.TUpdate(p);
            return Ok();
        }
        [HttpGet("GetById")]
        public IActionResult GetGuest(int id)
        {
            var vv = _GuestService.TGetByID(id);
            return Ok(vv);
        }
    }
}
