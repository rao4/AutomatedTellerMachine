﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having Trouble? Send us a message.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            // Todo: send message to HQ
            ViewBag.TheMessage = "Thanks, We got your message.";

            return View();
        }

        public ActionResult Foo()
        {
            return View("About");
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPMVC5SERIAL1";
            if (letterCase == "lower")
            {
                Content(serial.ToLower());
            }
            //return Content(serial);
            return Json(new { name = "serial", value = serial }, JsonRequestBehavior.AllowGet);
        }
    }
}