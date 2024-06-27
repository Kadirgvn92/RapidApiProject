using static RapidApiProject.Models.WeatherApiResponse;

namespace RapidApiProject.Models;

public class NewsViewModel
{
    public bool success { get; set; }
    public List<NewsData> result { get; set; }
}

public class NewsData
{
    public string key { get; set; }
    public string url { get; set; }
    public string description { get; set; }
    public string image { get; set; }
    public string name { get; set; }
    public string source { get; set; }
}
