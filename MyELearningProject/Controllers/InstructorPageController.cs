using MyELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class InstructorPageController : Controller
    {
        ELearninngContext context = new ELearninngContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult InstructorHeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult InstructorSpinnerPartial()
        {
            return PartialView();
        }

        public PartialViewResult InstructorNavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult InstructorHeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult InstructorInstructorPartial()
        {
            var values = context.Instructors.ToList();
            return PartialView(values);
        }


        public PartialViewResult InstructorFooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult InstructorScriptPartial()
        {
            return PartialView();
        }
    }
}