using Microsoft.AspNetCore.Mvc;

namespace RapidApiProject.ViewComponents;

public class _MainPostPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {

        return View();
    }
}
