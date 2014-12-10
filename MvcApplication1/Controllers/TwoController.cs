using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class TwoController : Controller
    {
        //
        // GET: /Two/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult View1()
        {
            ViewBag.info1 = "Welcome to ViewBag";
            ViewBag.info2 = "Second Info";
            ViewBag.info3 = "Third Info";

            ViewData["color"] = "Red";
            ViewData["game"] = "Cricket";
            ViewData["value"] = 100;

            var obj = new MyClass();
            obj.Value1 = 100;
            obj.Value2 = "Testing";

            ViewData["objInfo"] = obj;
            TempData["objinfo"] = obj;

            var li = new List<MyClass>();
            var obj1 = new MyClass();
            obj1.Value1 = 10;
            obj1.Value2 = "Ten";

            var obj2 = new MyClass();
            obj2.Value1 = 20;
            obj2.Value2 = "Twenty";

            li.Add(obj1); 
            li.Add(obj2);
            ViewData["obj"] = li;

            return View();
        }
        public class MyClass
        {
            public int Value1 { get; set; }
            public string Value2 { get; set; }

        }
    }
}
