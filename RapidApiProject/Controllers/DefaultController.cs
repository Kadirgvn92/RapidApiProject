using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiProject.Models;
using RestSharp;

namespace RapidApiProject.Controllers;
public class DefaultController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult GetWeather()
    {
        var client = new RestClient("https://api.collectapi.com/weather/getWeather?data.lang=tr&data.city=ankara");
        var request = new RestRequest(Method.GET);
        request.AddHeader("authorization", "apikey 3vLvr8BLRuJZH5KJDssMMM:3s0zddCcs13UHM3tSE1TPp");
        request.AddHeader("content-type", "application/json");
        IRestResponse response = client.Execute(request);

        if (response.IsSuccessful)
        {
            var weatherApiResponse = JsonConvert.DeserializeObject<WeatherApiResponse>(response.Content);
            return Ok(weatherApiResponse); // API'den doğru şekilde veri alındığında 200 OK yanıtıyla veriyi döndür
        }

        return BadRequest("Hava durumu bilgisi alınamadı.");
    }
    
}

