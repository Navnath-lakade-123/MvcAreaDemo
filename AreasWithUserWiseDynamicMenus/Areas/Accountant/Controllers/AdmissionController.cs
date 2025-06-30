using Microsoft.AspNetCore.Mvc;

namespace AreasWithUserWiseDynamicMenus.Areas.Accountant.Controllers
{
    [Area("Accountant")]
    public class AdmissionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
