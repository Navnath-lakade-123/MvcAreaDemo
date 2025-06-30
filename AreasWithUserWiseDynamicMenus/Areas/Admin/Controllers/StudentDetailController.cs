using Microsoft.AspNetCore.Mvc;

namespace AreasWithUserWiseDynamicMenus.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
