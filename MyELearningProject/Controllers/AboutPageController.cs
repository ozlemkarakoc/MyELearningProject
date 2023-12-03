using MyELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class AboutPageController : Controller
    {
        ELearninngContext context = new ELearninngContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult AboutHeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult AboutSpinnerPartial()
        {
            return PartialView();
        }
        public PartialViewResult AboutNavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult AboutHeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult AboutServicePartial()
        {
            return PartialView();
        }
        public PartialViewResult AboutAboutPartial()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }
        public PartialViewResult AboutTeamPartial()
        {
            var values = context.Instructors.ToList();
            return PartialView(values);
        }
        public PartialViewResult AboutTestimonialPartial()
        {
            var values = context.Testimonials.ToList();
            return PartialView(values);
        }
        public PartialViewResult AboutFooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult AboutScriptPartial()
        {
            return PartialView();
        }
    }
}