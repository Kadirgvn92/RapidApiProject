using Microsoft.AspNetCore.Mvc;

namespace RapidApiProject.Controllers;
public class DefaultController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
