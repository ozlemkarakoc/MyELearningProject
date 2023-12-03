using MyELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class AdminDashboardController : Controller
    {
        ELearninngContext context = new ELearninngContext();
        [Authorize]
        public ActionResult Index()
        {
            //var values1 = Session["CurrentMail"].ToString();
            var values = context.Admins.ToList();
            return View();
        }
    }
}