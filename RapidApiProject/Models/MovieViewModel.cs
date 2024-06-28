namespace RapidApiProject.Models;

public class MovieViewModel
{
    public bool success { get; set; }
    public List<MovieData> result { get; set; }
}

public class MovieData
{
    public string url { get; set; }
    public string img { get; set; }
    public string year { get; set; }
    public string rate { get; set; }
    public string name { get; set; }

}
