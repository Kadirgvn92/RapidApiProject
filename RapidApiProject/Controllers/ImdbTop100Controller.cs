using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiProject.Models;
using RestSharp;

namespace RapidApiProject.Controllers;
public class ImdbTop100Controller : Controller
{
    public IActionResult Index()
    {

        return View();
    }

}
