using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var vv=_staffService.TGetList();
            return Ok(vv);
        }
        [HttpPost]
        public IActionResult AddStaff(Staff p)
        {
            _staffService.TInsert(p);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            var vv=_staffService.TGetByID(id);
            _staffService.TDelete(vv);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStuff(Staff p)
        {
            _staffService.TUpdate(p);
            return Ok();
        }
        [HttpGet("GetStaff")]
        public IActionResult GetStaff(int id)
        {
            var vv= _staffService.TGetByID(id);
            return Ok(vv);
        }
    }
}
