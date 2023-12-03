using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class AddressController : Controller
    {
        ELearninngContext context = new ELearninngContext();
        public ActionResult Index()
        {
            var values = context.Addresses.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddAddress()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAddress(Address address)
        {
            context.Addresses.Add(address);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAddress(int id)
        {
            var values = context.Addresses.Find(id);
            context.Addresses.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateAddress(int id)
        {
            var values = context.Addresses.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateAddress(Address address)
        {
            var value = context.Addresses.Find(address.AddressID);
            value.Title = address.Title;
            value.Description = address.Description;
            value.Email = address.Email;
            value.AddressInfo = address.AddressInfo;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}