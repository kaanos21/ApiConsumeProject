using Microsoft.AspNetCore.Mvc;

namespace RapidApiConsume_.Controllers
{
    public class BookingByCityController : Controller
    {
        public async Task<IActionResult> Index(string cityID)
        {
            return View();
        }
    }
}
