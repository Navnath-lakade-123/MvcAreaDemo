using Microsoft.AspNetCore.Mvc;

namespace AreasWithUserWiseDynamicMenus.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    public class SalaryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
