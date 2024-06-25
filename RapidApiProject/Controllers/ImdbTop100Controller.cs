using Microsoft.AspNetCore.Mvc;

namespace RapidApiProject.Controllers;
public class ImdbTop100Controller : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
