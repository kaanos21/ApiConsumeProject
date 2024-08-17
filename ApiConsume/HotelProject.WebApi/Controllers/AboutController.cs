using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService AboutService)
        {
            _aboutService = AboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var vv = _aboutService.TGetList();
            return Ok(vv);
        }
        [HttpPost]
        public IActionResult AddAbout(About p)
        {
            _aboutService.TInsert(p);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var vv = _aboutService.TGetByID(id);
            _aboutService.TDelete(vv);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStuff(About p)
        {
            _aboutService.TUpdate(p);
            return Ok();
        }
        [HttpGet("GetAbout")]
        public IActionResult GetAbout(int id)
        {
            var vv = _aboutService.TGetByID(id);
            return Ok(vv);
        }
    }
}
