using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entities;

namespace MyELearningProject.Controllers
{
    public class LoginController : Controller
    {
        ELearninngContext context = new ELearninngContext();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Student student)
        {
            //var values = context.Students.FirstOrDefault(x => x.Email == student.Email && x.Password == student.Password);

            //if(values !=null)
            //{
            //    FormsAuthentication.SetAuthCookie(values.Email, false);
            //    Session["Email"] = values.Email;
            //    Session.Timeout = 60;
            //    return RedirectToAction("Index", "Profile");
            //}
            //return View();


            var values = context.Students.FirstOrDefault(x => x.Email == student.Email && x.Password == student.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Email, false);
                Session["Email"] = values.Email.ToString();
                return RedirectToAction("Index", "Profile");
            }
            else
            {
                return View();
            }
        }
    }
}