using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using roshankhadka;

namespace roshankhadka.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(user usr)
        {
            Entities5 dbObject = new Entities5();
            var checkUser = dbObject.users.Where(l => l.user_name.Equals(usr.user_name) && l.user_password.Equals(usr.user_password)).FirstOrDefault();
            if (checkUser != null)
            {
                var loggeduser = dbObject.users.Where(l => l.user_name.Equals(usr.user_name)).FirstOrDefault();
                Session["user_name"] = loggeduser.user_name.ToString();
                Session["user_id"] = loggeduser.user_id.ToString();
                Session["user_type"] = loggeduser.user_type.ToString();

                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.msg = "Invalid Username or Password";

            }
            return View();
        }
        public ActionResult DashBoard()
        {
            return View();

        }

    }
}


