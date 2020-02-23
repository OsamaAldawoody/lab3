using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab3.Controllers
{
    public class Lab3Controller : Controller
    {
        // GET: Lab3
        lab3Model db = new lab3Model();
        
        public ActionResult Index()
        {
            
            return View();
        }
    }
}