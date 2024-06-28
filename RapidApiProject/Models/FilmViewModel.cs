namespace RapidApiProject.Models;

public class FilmViewModel
{
    public bool success { get; set; }
    public List<FilmData> result { get; set; }
}

public class FilmData
{
    public string type { get; set; }
    public string director { get; set; }
    public string summary { get; set; }
    public string name { get; set; }
    public string image { get; set; }

}
