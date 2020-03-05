using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJsMVC.Models;

namespace AngularJsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.AngularObject = GetTalks();
            return View("Index");
        }
        private string GetTalks()
        {
            var emp = new[]

                {
                new Talk { Name = "Jones", City = "Lisbon", Id = 10 },
                new Talk { Name = "Henry", City = "Zurich", Id = 11 },
                new Talk { Name = "Hunter", City = "Munich", Id = 12 }
            };

            return JsonConvert.SerializeObject(emp, Formatting.None);

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