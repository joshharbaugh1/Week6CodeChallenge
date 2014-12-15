using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week6CodeChallenge.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        [HttpGet]
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(Models.ContactForm inputData)
        {
            Models.sp5JoshEntities1 db = new Models.sp5JoshEntities1();
            db.ContactForms.Add(inputData);
            db.SaveChanges();
            return Content("Thanks");
        }
    }
}