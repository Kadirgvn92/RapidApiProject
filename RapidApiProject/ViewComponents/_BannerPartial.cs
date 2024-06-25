using Microsoft.AspNetCore.Mvc;

namespace RapidApiProject.ViewComponents;

public class _BannerPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
