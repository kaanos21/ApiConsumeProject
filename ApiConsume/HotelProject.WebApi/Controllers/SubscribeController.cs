using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscibeService _subscribeService;

        public SubscribeController(ISubscibeService SubscribeService)
        {
            _subscribeService = SubscribeService;
        }

        [HttpGet]
        public IActionResult SubscribeList()
        {
            var vv = _subscribeService.TGetList();
            return Ok(vv);
        }
        [HttpPost]
        public IActionResult AddSubscribe(Subscribe p)
        {
            _subscribeService.TInsert(p);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscribe(int id)
        {
            var vv = _subscribeService.TGetByID(id);
            _subscribeService.TDelete(vv);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStuff(Subscribe p)
        {
            _subscribeService.TUpdate(p);
            return Ok();
        }
        [HttpGet("Id ye göre")]
        public IActionResult GetSubscribe(int id)
        {
            var vv = _subscribeService.TGetByID(id);
            return Ok(vv);
        }
    }
}
