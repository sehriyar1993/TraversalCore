using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using TraversalProje.Areas.Admin.Models;

namespace TraversalProje.Areas.Admin.Controllers
{
    public class ApiExchangeController : Controller
    {
        [Area("Admin")]
        public async Task<IActionResult> Index()
        {
            List<BookingExchangeModel> bookingExchangeModels = new List<BookingExchangeModel>();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?currency=AZN&locale=en-gb"),
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
                var values = JsonConvert.DeserializeObject<BookingExchangeModel>(body);
                return View(values.exchange_rates);

                //Console.WriteLine(body);
            }

            return View();
        }
    }
}
