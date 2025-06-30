using Microsoft.AspNetCore.Mvc;

namespace AreasWithUserWiseDynamicMenus.Areas.Student.Controllers
{
    [Area("Student")]
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
