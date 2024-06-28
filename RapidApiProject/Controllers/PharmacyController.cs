using Microsoft.AspNetCore.Mvc;

namespace RapidApiProject.Controllers;
public class PharmacyController : Controller
{
    public IActionResult Index()
    {


        return View();
    }
}
