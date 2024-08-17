using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _ContactService;

        public ContactController(IContactService ContactService)
        {
            _ContactService = ContactService;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var vv = _ContactService.TGetList();
            return Ok(vv);
        }
        [HttpPost]
        public IActionResult AddContact(Contact p)
        {
            _ContactService.TInsert(p);
            return Ok();
        }
        [HttpGet]
        public IActionResult InboxListContact()
        {
            var values= _ContactService.TGetList();
            return Ok(values);
        }
        [HttpGet("GetSendMessage")]
        public IActionResult GetSendMessage(int id)
        {
            var vv = _ContactService.TGetByID(id);
            return Ok(vv);
        }
        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var vv = _ContactService.TGetByID(id);
            _ContactService.TDelete(vv);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateContact(Contact p)
        {
            _ContactService.TUpdate(p);
            return Ok();
        }
        [HttpGet("GetContact")]
        public IActionResult GetContact(int id)
        {
            var vv = _ContactService.TGetByID(id);
            return Ok(vv);
        }
    }
}
