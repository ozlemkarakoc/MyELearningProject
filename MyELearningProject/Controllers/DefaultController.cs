using MyELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class DefaultController : Controller
    {
        ELearninngContext context = new ELearninngContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult DefaultHeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult DefaultSpinnerPartial()
        {
            return PartialView();
        }
        public PartialViewResult DefaultNavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult DefaultCarouselPartial()
        {
            return PartialView();
        }
        public PartialViewResult DefaultServicePartial()
        {
            return PartialView();
        }
        public PartialViewResult DefaultAboutPartial()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultCategoryPartial()
        {
            var values = context.Categories.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultCoursePartial()
        {
            var values = context.Courses.Take(9).ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultInstructorPartial()
        {
            var values = context.Instructors.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultTestimonialPartial()
        {
            var values = context.Testimonials.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultFooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult DefaultScriptPartial()
        {
            return PartialView();
        }
    }
}