using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _BookingService;

        public BookingController(IBookingService BookingService)
        {
            _BookingService = BookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var vv = _BookingService.TGetList();
            return Ok(vv);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking p)
        {
            _BookingService.TInsert(p);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var vv = _BookingService.TGetByID(id);
            _BookingService.TDelete(vv);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBooking(Booking p)
        {
            _BookingService.TUpdate(p);
            return Ok();
        }
        [HttpGet("GetBooking")]
        public IActionResult GetBooking(int id)
        {
            var vv = _BookingService.TGetByID(id);
            return Ok(vv);
        }
        [HttpPut("StatusToApproved")]
        public IActionResult aaa(Booking booking)
        {
            _BookingService.TBookingStatusChangeApproved(booking);
            return Ok();
        }
        [HttpPut("StatusToApproved2")]
        public IActionResult bbb(int id)
        {
            _BookingService.TBookingStatusChangeApproved2(id);
            return Ok();
        }
    }
}
