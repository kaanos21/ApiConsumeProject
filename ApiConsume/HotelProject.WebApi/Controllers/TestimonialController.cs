using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public IActionResult GetTestimonials()
        {
            var testimonials = _testimonialService.TGetList();
            return Ok(testimonials);
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonialService.TInsert(testimonial);
            return Ok();
        }

        [HttpDelete("DeleteById")]
        public IActionResult DeleteTestimonial(int id)
        {
            var testimonial = _testimonialService.TGetByID(id);
            if (testimonial == null)
            {
                return NotFound();
            }
            _testimonialService.TDelete(testimonial);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _testimonialService.TUpdate(testimonial);
            return Ok();
        }

        [HttpGet("GetById")]
        public IActionResult GetTestimonialById(int id)
        {
            var testimonial = _testimonialService.TGetByID(id);
            if (testimonial == null)
            {
                return NotFound();
            }
            return Ok(testimonial);
        }
    }
}
