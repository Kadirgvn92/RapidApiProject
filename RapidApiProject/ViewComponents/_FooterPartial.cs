using Microsoft.AspNetCore.Mvc;

namespace RapidApiProject.ViewComponents;

public class _FooterPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
