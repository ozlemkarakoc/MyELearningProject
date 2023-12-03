using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class ContactPageController : Controller
    {
        ELearninngContext context = new ELearninngContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult ContactHeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult ContactSpinnerPartial()
        {
            return PartialView();
        }
        public PartialViewResult ContactNavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult ContactHeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult ContactFooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult ContactScriptPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult ContactContactPartial()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult ContactContactPartial(ContactUs contactUs)
        {
            context.ContactUss.Add(contactUs);
            context.SaveChanges();
            return PartialView();
        }
    }
}