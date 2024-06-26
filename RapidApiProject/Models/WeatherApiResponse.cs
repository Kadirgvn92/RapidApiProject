﻿namespace RapidApiProject.Models;

public class WeatherApiResponse
{
    public bool success { get; set; }
    public string city { get; set; }
    public List<WeatherData> result { get; set; }


    public class WeatherData
    {
        public string date { get; set; }
        public string day { get; set; }
        public string icon { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public string degree { get; set; }
        public string min { get; set; }
        public string max { get; set; }
        public string night { get; set; }
        public string humidity { get; set; }
    }
}
