using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class OneController : Controller
    {
        //
        // GET: /One/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult View1()
        {
            return View();
        }

        public ActionResult View2()
        {
            return Content("Hello World");
        }

        public String View3()
        {
            return "Hi";
        }

        public int view4()
        {
            return 100;
        }

        public ActionResult MyView5()
        {
            return View("View5");
        }
    }
}
