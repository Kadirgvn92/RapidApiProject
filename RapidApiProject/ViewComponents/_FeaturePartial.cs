using Microsoft.AspNetCore.Mvc;

namespace RapidApiProject.ViewComponents;

public class _FeaturePartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
