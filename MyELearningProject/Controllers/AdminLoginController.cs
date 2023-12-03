using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MyELearningProject.Controllers
{
    public class AdminLoginController : Controller
    {
        ELearninngContext context = new ELearninngContext();
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var values = context.Admins.FirstOrDefault(x => x.Name == admin.Name && x.Password == admin.Password);
            if(values !=null)
            {
                FormsAuthentication.SetAuthCookie(values.Name, false);
                Session["Name"] = values.Name.ToString();
                return RedirectToAction("Index", "AdminDashboard");
            }
            else
            {
                ViewBag.ErrorMessage = "Kullanıcı adı veya şifre yanlış.";
                return View();
            }
        }
    }
}