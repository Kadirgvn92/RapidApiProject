using Microsoft.AspNetCore.Mvc;

namespace RapidApiProject.ViewComponents;

public class _LatestNewsPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
