using Microsoft.AspNetCore.Mvc;

namespace AreasWithUserWiseDynamicMenus.Areas.Student.Controllers
{
    [Area("Student")]
    public class LeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
