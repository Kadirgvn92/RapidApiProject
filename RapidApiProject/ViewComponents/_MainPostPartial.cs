using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiProject.Models;
using RestSharp;

namespace RapidApiProject.ViewComponents;

public class _MainPostPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var client = new RestClient("https://api.collectapi.com/news/getNews?country=tr&tag=general");
        var request = new RestRequest(Method.GET);
        request.AddHeader("authorization", "apikey 3vLvr8BLRuJZH5KJDssMMM:3s0zddCcs13UHM3tSE1TPp");
        request.AddHeader("content-type", "application/json");
        IRestResponse response = client.Execute(request);

        if (response.IsSuccessful)
        {
            var apiResponse = JsonConvert.DeserializeObject<NewsViewModel>(response.Content);
            return View(apiResponse);
        }
        return View();
    }
}
