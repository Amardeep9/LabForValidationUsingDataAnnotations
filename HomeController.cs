using LabForValidationUsingDataAnnotations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabForValidationUsingDataAnnotations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee Emp)
        {

            if (ModelState.IsValid)
            {
                return RedirectToAction("Message");
            }

            return View();








            //if (!string.IsNullOrEmpty(Emp.username))
            //{
            //    return RedirectToAction("Message");
            //}
            //else
            //{
            //    ModelState.AddModelError("username", "Username is Required");
            //    return View();
            //}
        }

        public ActionResult Message()
        {
            return View();
        }
    }
}