using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using TraversalProje.Areas.Admin.Models;

namespace TraversalProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ApiMovieController : Controller
    {
        public async Task<IActionResult> Index()
        {

            List<ApiMovieViewModel> apiMovies = new List<ApiMovieViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "X-RapidAPI-Key", "0573a1503amsh31f3cafc968bc50p158dbajsnfb4d3ce97214" },
        { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                apiMovies= JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
                //Console.WriteLine(body);
                return View(apiMovies);
            }

        }
    }
}
