using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyELearningProject.DAL.Context;

namespace MyELearningProject.Controllers
{
    public class InstructorAnalysisController : Controller
    {
        
        ELearninngContext context = new ELearninngContext();
        public ActionResult Index()
        {
            return View();
        }
        
        public PartialViewResult InstructorPanelPartial()
        {
            int id = 1;
            //string InsructorID= Request.QueryString["InstructorID"];

            var values = context.Instructors.Where(x => x.InstructorID == id).ToList();
            var v1 = context.Instructors.Where(x => x.Name == "Ahmet" && x.Surname == "Karakoç").Select(y => y.InstructorID).FirstOrDefault();
            ViewBag.courseCount = context.Courses.Where(x => x.InstructorID == 1).Count();
            var v2 = context.Courses.Where(x => x.InstructorID == v1).Select(y => y.CourseID).ToList();
            ViewBag.commentCount = context.Comments.Where(x => v2.Contains(x.CourseID)).Count();
            return PartialView(values);


        }
        public PartialViewResult CommentPartial()
        {
            //select InstructorID from Instructors where Name='Ahmet' and Surname='Karakoç'=v1
            var v1 = context.Instructors.Where(x => x.Name == "Murat" && x.Surname == "Yücedağ").Select(y => y.InstructorID).FirstOrDefault();
            
           

            //Select CourseID From Courses Where InstructorID=v2
            var v2 = context.Courses.Where(x => x.InstructorID == v1).Select(y => y.CourseID).ToList();

            //Select * from Comments where CourseID in 
            var v3 = context.Comments.Where(x => v2.Contains(x.CourseID)).ToList();

            return PartialView(v3);
        }
        public PartialViewResult CourseListByInstructor()
        {
            var values = context.Courses.Where(x => x.InstructorID == 1).ToList();
            return PartialView(values);
        }
        public PartialViewResult InstructorCommunicationPartial()
        {
            return PartialView();
        }
    }
}