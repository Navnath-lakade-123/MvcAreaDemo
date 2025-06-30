using Microsoft.AspNetCore.Mvc;

namespace AreasWithUserWiseDynamicMenus.Areas.Accountant.Controllers
{
    [Area("Accountant")]
    public class FeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
