﻿using System;
using System.Web.Mvc;

namespace Jquery.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Window()
        {
            return View();
        }

        public ActionResult Selectors()
        {
             return View();
        }
        public ActionResult  Input()
        {
            return View();
        }
        public ActionResult SelectorExtended()
        {
            return View();
        }
        public ActionResult Animation()
        {
            return View();
        }
        [ActionName("JsonPage")]
        public ActionResult JSON()
        {
            return View();
        }

        public ActionResult JqueryClass()
        {
            return View();
        }
        public ActionResult Events() {
            return View();
        }

        public ActionResult ImageAnimation()
        {
            return View();
        }
        public ActionResult Ajax1()
        {
            return View();
        }
      
    }


}