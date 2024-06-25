using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiProject.Models;
using RestSharp;
using System.Threading.Tasks;

namespace RapidApiProject.ViewComponents
{
    public class _NavbarPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new RestClient("https://api.collectapi.com/imdb/imdbSearchById?movieId=tt1375666");
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "apikey 3vLvr8BLRuJZH5KJDssMMM:3s0zddCcs13UHM3tSE1TPp");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var movieResponse = JsonConvert.DeserializeObject<NavbarMovieViewModel>(response.Content);
                return View(movieResponse);
            }
            else
            {
                // Hata durumu için uygun bir işlem yapabilirsiniz
                return View(new NavbarMovieViewModel()); // Boş bir model gönderilebilir
            }
        }
    }
}
