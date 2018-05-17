using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Joro.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default/Index?1=value&b=value
        public ActionResult Index(int a = 0, int b= 0)
        {
            ViewBag.Title = "Примерно съдържание";

            ViewBag.p = Request.Params;

            ViewBag.a =a; //a 
            ViewBag.b =b; //b
            ViewBag.result = ViewBag.a + ViewBag.b;

            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            ViewBag.p = Request.Params;
            ViewBag.a = Int32.Parse(Request.Params["a"]);
            ViewBag.b = Int32.Parse(Request.Params["b"]);
            ViewBag.resultat = ViewBag.a + ViewBag.b;
            return View();
        }
    }
    
}