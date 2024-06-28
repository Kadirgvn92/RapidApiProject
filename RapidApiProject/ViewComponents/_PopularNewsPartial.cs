using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiProject.Models;
using RestSharp;

namespace RapidApiProject.ViewComponents;

public class _PopularNewsPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var client = new RestClient("https://imdb-top-100-movies.p.rapidapi.com/");
        var request = new RestRequest(Method.GET);
        request.AddHeader("x-rapidapi-key", "a0a48114fdmsh17deeff65810c77p14e99bjsn37343ba56f23");
        request.AddHeader("x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com");
        IRestResponse response = client.Execute(request);

        if (response.IsSuccessful)
        {
            var data = JsonConvert.DeserializeObject<List<NavbarMovieViewModel>>(response.Content);
            return View(data);  
        }
        return View();
    }
}
