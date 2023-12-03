using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entities;

namespace MyELearningProject.Controllers
{
    public class ProfileController : Controller
    {
        ELearninngContext context = new ELearninngContext();
        public ActionResult Index()
        {
            //string values = Session["CurrentMail"].ToString();
            //ViewBag.mail = Session["CurrentMail"];
            //ViewBag.name = context.Students.Where(x => x.Email == values).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            //ViewBag.ImageUrl = context.Students.Where(x => x.Email == values).Select(y => y.ImageUrl).FirstOrDefault();
            //ViewBag.id = context.Students.Where(x => x.Email == values).Select(x => x.StudentID).FirstOrDefault();
            return View();
        }
        public ActionResult MyCourseList()
        {
            //string values = Session["CurrentMail"].ToString();
            //int id = context.Students.Where(x => x.Email == values).Select(y => y.StudentID).FirstOrDefault();
            //var courseList = context.Processes.Where(x => x.StudentID == id).ToList();
            var values = context.Courses.ToList();
            return View(values);
        }
       [HttpGet]
       public ActionResult RateCourse(int id)
        {
            var values = context.Courses.Find(id);
            var courseTitle = context.Courses.Where(x => x.CourseID == id).Select(x => x.Title).FirstOrDefault();
            ViewBag.couseName = courseTitle.ToString();
            ViewBag.v = id;
            return View();
        }
        [HttpPost]
        public ActionResult RateCourse(Review review)
        {
            var email = Session["CurrentMail"];
            var studentID = context.Students.Where(x => x.Email == email.ToString()).Select(x => x.StudentID).FirstOrDefault();
            var searchResult = context.Reviews.Where(y => y.StudentID == studentID);
       
            context.SaveChanges();
            return RedirectToAction("Index", "Profile");
        }

    }
}