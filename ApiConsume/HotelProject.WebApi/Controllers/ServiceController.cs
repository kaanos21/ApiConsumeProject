using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService ServiceService)
        {
            _serviceService = ServiceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var vv = _serviceService.TGetList();
            return Ok(vv);
        }
        [HttpPost]
        public IActionResult AddService(Service p)
        {
            _serviceService.TInsert(p);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var vv = _serviceService.TGetByID(id);
            _serviceService.TDelete(vv);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStuff(Service p)
        {
            _serviceService.TUpdate(p);
            return Ok();
        }
        [HttpGet("GetService")]
        public IActionResult GetService(int id)
        {
            var vv = _serviceService.TGetByID(id);
            return Ok(vv);
        }
    }
}
