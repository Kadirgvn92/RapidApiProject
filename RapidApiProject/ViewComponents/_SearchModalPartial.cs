using Microsoft.AspNetCore.Mvc;

namespace RapidApiProject.ViewComponents;

public class _SearchModalPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();  
    }
}
