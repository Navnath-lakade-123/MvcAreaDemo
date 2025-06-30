using Microsoft.AspNetCore.Mvc;

namespace AreasWithUserWiseDynamicMenus.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
