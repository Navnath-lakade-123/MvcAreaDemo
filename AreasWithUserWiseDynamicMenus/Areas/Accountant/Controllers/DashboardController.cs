using Microsoft.AspNetCore.Mvc;

namespace AreasWithUserWiseDynamicMenus.Areas.Accountant.Controllers
{
    [Area("Accountant")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
