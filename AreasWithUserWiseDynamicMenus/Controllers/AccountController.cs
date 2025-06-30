using AreasWithUserWiseDynamicMenus.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AreasWithUserWiseDynamicMenus.Controllers
{
    public class AccountController : Controller
    {
        DemoDbContext db;
        public AccountController(DemoDbContext db)
        {
            this.db = db;
        }
        public IActionResult Login()
        {
            //my new comment
            return View();
        }

        [HttpPost]
        public IActionResult Login(Tbluser u)
        {
            Tbluser user = db.Tblusers.ToList().FirstOrDefault(e => e.UserName.ToLower().Equals(u.UserName.ToLower()) & e.Password.Equals(u.Password));
            if (user != null)
            {
                Tblrole r = db.Tblroles.Find(user.RoleId);
                HttpContext.Session.SetString("role_name", r.RoleName.ToLower());

                Tbluser ur = new Tbluser()
                {
                    FullName = user.FullName,
                    RoleId = user.RoleId,
                    UserName = user.UserName,
                    UserId = user.UserId
                };
                
                HttpContext.Session.SetString("user", JsonConvert.SerializeObject(ur));
                string url = "";
                switch (r.RoleName.ToLower())
                {
                    case "admin":
                        {
                            url = "/Admin/Dashboard/Index";
                            break;
                        }
                    case "accountant":
                        {
                            url = "/Accountant/Dashboard/Index";
                            break;
                        }
                    case "student":
                        {
                            url = "/Student/Dashboard/Index";
                            break;
                        }
                    case "teacher":
                        {
                            url = "/Teacher/Dashboard/Index";
                            break;
                        }

                }
                return Redirect(url);

            }
            else
            {
                ViewBag.msg = "Invalid user name or password";
                return View();

            }


        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("user");
            HttpContext.Session.Remove("role_name");
            return RedirectToAction("Login");
        }
    }
}
