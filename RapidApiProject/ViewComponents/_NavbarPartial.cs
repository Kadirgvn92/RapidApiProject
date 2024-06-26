using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiProject.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RapidApiProject.ViewComponents
{
    public class _NavbarPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            int dailyIndex = GetDailyIndex();
            var client = new RestClient("https://imdb-top-100-movies.p.rapidapi.com/");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "1b835557bamsh51f42a1ec11b465p131830jsn7e5d47c9227c");
            request.AddHeader("x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var apiResponse = JsonConvert.DeserializeObject<List<NavbarMovieViewModel>>(response.Content);

                // Günlük indeks için kullanılacak sayısal bir fonksiyon veya algoritma (örneğin tarih bazlı bir hesaplama)
                int index = dailyIndex % apiResponse.Count;

                var dailyMovie = apiResponse[index];

                return View(dailyMovie);

            }

            return View(new NavbarMovieViewModel()); // Return an empty model if there is an error or the list is empty
        }
        private int GetDailyIndex()
        {
            // Bugünün tarihini alalım
            DateTime today = DateTime.Today;

            // Örneğin, günün ay içindeki indeksini ve yıl içindeki indeksini kullanarak bir indeks oluşturalım
            int dayIndex = today.Day; // Günün ay içindeki indeksi (1-31)
            int monthIndex = today.Month; // Ayın yıl içindeki indeksi (1-12)
            int yearIndex = today.Year; // Yıl

            // Basit bir şekilde bu değerleri birleştirip bir indeks oluşturalım
            int dailyIndex = dayIndex + (monthIndex * 100) + (yearIndex * 10000);

            return dailyIndex;
        }

    }
}
