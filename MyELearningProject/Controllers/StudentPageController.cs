using MyELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class StudentPageController : Controller
    {
        ELearninngContext context = new ELearninngContext();
        public ActionResult Index()
        {
            return View();
        }

        // public ActionResult PartialHead()
        //{
        //    return PartialView();
        //}

        //public ActionResult PartialPreloader()
        //{
        //    return PartialView();
        //}

        //public ActionResult PartialNavbar()
        //{
        //    string values = Session["CurrentMail"].ToString();
        //    ViewBag.studentName = values;
        //    int id =context.Students.Where(x => x.Name == values).Select(y => y.StudentID).FirstOrDefault();
        //    return PartialView();
        //}

        //public ActionResult PartialSidebar()
        //{
        //    return PartialView();
        //}

        //public ActionResult PartialPageRowTitle()
        //{
        //    return PartialView();
        //}

        //public ActionResult PartialFooter()
        //{
        //    return PartialView();
        //}

        //public ActionResult PartialScript()
        //{
        //    return PartialView();
        //}
    }
}