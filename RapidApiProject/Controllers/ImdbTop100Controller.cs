using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiProject.Models;
using RestSharp;

namespace RapidApiProject.Controllers;
public class ImdbTop100Controller : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetWeather()
    {
        var client = new RestClient("https://api.collectapi.com/weather/getWeather?data.lang=tr&data.city=ankara");
        var request = new RestRequest(Method.GET);
        request.AddHeader("authorization", "apikey 3vLvr8BLRuJZH5KJDssMMM:3s0zddCcs13UHM3tSE1TPp");
        request.AddHeader("content-type", "application/json");
        IRestResponse response = client.Execute(request);

        if (response.IsSuccessful)
        {
            // API'den gelen JSON verisini C# nesnesine dönüştür
            var weatherData = JsonConvert.DeserializeObject<WeatherApiResponse>(response.Content);

            // Gerekli verileri JSON formatında geri döndür
            var responseData = new
            {
                temperature = weatherData.degree,
                location = "Ankara", // Burası API'den gelen veriden alınmalı
                date = DateTime.Now.ToString("ddd. dd MMM yyyy") // Örnek bir tarih formatı, API'den gelen veriye göre ayarlanmalı
            };

            return Json(responseData);
        }

        return BadRequest("Hava durumu bilgisi alınamadı.");
    }
}
