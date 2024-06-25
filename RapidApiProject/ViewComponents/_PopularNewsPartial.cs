using Microsoft.AspNetCore.Mvc;

namespace RapidApiProject.ViewComponents;

public class _PopularNewsPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
