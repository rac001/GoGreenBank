using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationWCF.Models;

namespace WebApplicationWCF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(EmployeeModal empmodalobj)
        {
            if (ModelState.IsValid)
            {
                MainService.EmployeeServiceClient empserv = new MainService.EmployeeServiceClient();
                int serviceInsert = empserv.Insert(empmodalobj.Name, empmodalobj.Email, empmodalobj.Phone, empmodalobj.Gender);
            }
            else { ModelState.AddModelError("", "Can Not Insert"); }
                return RedirectToAction("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}