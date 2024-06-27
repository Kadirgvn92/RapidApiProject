namespace RapidApiProject.Models;

public class BookViewModel
{
    public bool success { get; set; }
    public List<BookData> result { get; set; }
}
public class BookData
{
    public string url { get; set; }
    public string indirim { get; set; }
    public string fiyat { get; set; }
    public string yayın { get; set; }
    public string yazar { get; set; }
    public string title { get; set; }
    public string image { get; set; }

}