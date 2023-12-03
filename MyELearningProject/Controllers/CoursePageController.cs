using MyELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MyELearningProject.Controllers
{
    public class CoursePageController : Controller
    {
        ELearninngContext context = new ELearninngContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult CourseHeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult CourseSpinnerPartial()
        {
            return PartialView();
        }
        public PartialViewResult CourseNavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult CourseHeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult CourseFooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult CourseScriptPartial()
        {
            return PartialView();
        }
        public PartialViewResult CourseCoursePartial()
        {
            var values = context.Courses.Take(9).ToList();
            return PartialView(values);
        }
        public PartialViewResult CourseCategoryPartial()
        {
            var values = context.Categories.ToList();
            return PartialView(values);
        }
        public PartialViewResult CourseTestimonialPartial()
        {
            var values = context.Testimonials.ToList();
            return PartialView(values);
        }
    }
}