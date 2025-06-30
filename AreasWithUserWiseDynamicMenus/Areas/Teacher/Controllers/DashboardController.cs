using Microsoft.AspNetCore.Mvc;

namespace AreasWithUserWiseDynamicMenus.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
