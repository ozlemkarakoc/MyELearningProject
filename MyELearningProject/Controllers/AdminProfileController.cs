using MyELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class AdminProfileController : Controller
    {
        ELearninngContext context = new ELearninngContext();
        public ActionResult Index()
        {
            var values = context.Admins.ToList();
            return View(values);
        }
    }
}