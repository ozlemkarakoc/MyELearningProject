using MyELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class MessageController : Controller
    {
        ELearninngContext context = new ELearninngContext();
        public ActionResult Index()
        {
            var values = context.ContactUss.ToList();
            return View(values);
        }
        public ActionResult DeleteMessage(int id)
        {
            var values = context.ContactUss.Find(id);
            context.ContactUss.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}