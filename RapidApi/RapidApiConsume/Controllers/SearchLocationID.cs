using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume_.Models;
using System.Net.Http.Headers;

namespace RapidApiConsume_.Controllers
{
    public class SearchLocationID : Controller
    {
        public async Task<IActionResult> Index(string cityName)
        {
            List<BookingApiLocationSearchViewModel> list = new List<BookingApiLocationSearchViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/locations?name={cityName}&locale=en-gb"),
                Headers =
    {
        { "x-rapidapi-key", "da0c61577amsh87f33e2291e88d4p136182jsn8e6abda27db6" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                list = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);
                return View(list.Take(1).ToList());
            }
            
        }
    }
}
