using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _SendMessageService;

        public SendMessageController(ISendMessageService SendMessageService)
        {
            _SendMessageService = SendMessageService;
        }

        [HttpGet]
        public IActionResult SendMessageList()
        {
            var vv = _SendMessageService.TGetList();
            return Ok(vv);
        }
        [HttpPost]
        public IActionResult AddSendMessage(SendMessage p)
        {
            _SendMessageService.TInsert(p);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSendMessage(int id)
        {
            var vv = _SendMessageService.TGetByID(id);
            _SendMessageService.TDelete(vv);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSendMessage(SendMessage p)
        {
            _SendMessageService.TUpdate(p);
            return Ok();
        }
        [HttpGet("GetSendMessage")]
        public IActionResult GetSendMessage(int id)
        {
            var vv = _SendMessageService.TGetByID(id);
            return Ok(vv);
        }
    }
}
