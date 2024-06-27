namespace RapidApiProject.Models;

public class NamazViewModel
{
    public bool success { get; set; }
    public List<NamazData> result { get; set; }


    public class NamazData
    {
        public string saat { get; set; }
        public string vakit { get; set; }

    }
}
