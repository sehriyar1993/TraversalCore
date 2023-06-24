using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using TraversalProje.Areas.Admin.Models;

namespace TraversalProje.Areas.Admin
{
    [Area("Admin")]
    public class BookingHotelController : Controller
    {
        List<BookingHotelViewModel> bookingHotels = new List<BookingHotelViewModel>();

       
        [HttpGet]
        public async Task<IActionResult> GetCityDesID()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GetCityDesID(string p)
        {
            var client = new HttpClient();
            ViewBag.RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?locale=en-gb&name={p}");
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = ViewBag.RequestUri,
                Headers =
    {
        { "X-RapidAPI-Key", "0573a1503amsh31f3cafc968bc50p158dbajsnfb4d3ce97214" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    }
               
            };
            
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                return View();
            }
        }
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=popularity&adults_number=2&checkin_date=2023-05-27&filter_by_currency=AZN&dest_id=-735347&locale=en-us&checkout_date=2023-06-28&units=metric&room_number=1&dest_type=city&include_adjacency=true&children_number=2&page_number=0&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1"),
                Headers =
    {
        { "X-RapidAPI-Key", "0573a1503amsh31f3cafc968bc50p158dbajsnfb4d3ce97214" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<BookingHotelViewModel>(body);
                return View(values.results);
            }
            return View();
        }
    }
}
