using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiProject.Models;
using RestSharp;

namespace RapidApiProject.ViewComponents;

public class _FeaturePartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var client = new RestClient("https://imdb-top-100-movies.p.rapidapi.com/");
        var request = new RestRequest(Method.GET);
        request.AddHeader("x-rapidapi-key", "1b835557bamsh51f42a1ec11b465p131830jsn7e5d47c9227c");
        request.AddHeader("x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com");
        IRestResponse response = client.Execute(request);

        if (response.IsSuccessful)
        {
            var apiResponse = JsonConvert.DeserializeObject<List<NavbarMovieViewModel>>(response.Content);
            return View(apiResponse);
        }
        return View();
    }
}
