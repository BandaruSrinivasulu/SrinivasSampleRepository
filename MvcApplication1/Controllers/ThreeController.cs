using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class ThreeController : Controller
    {
        //Testing Purpose
        //Another Testing
        //
        // GET: /Three/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetDetailsUsingViewData()
        {
            var data = new List<Employee>();
            var obj1 = new Employee();
            obj1.Eno = 1001;
            obj1.Ename = "AAA";
            obj1.Salary = 1234.12;
            obj1.City = "Hyderabad";

            var obj2 = new Employee();
            obj2.Eno = 1002;
            obj2.Ename = "BBB";
            obj2.Salary = 4321.12;
            obj2.City = "Secunderabad";

            data.Add(obj1);
            data.Add(obj2);

            ViewData["info"] = data;

            return View();
        }

        public ActionResult GetDetailsUsingTempData()
        {
            var data = new List<Employee>();
            var obj1 = new Employee();
            obj1.Eno = 1001;
            obj1.Ename = "AAA";
            obj1.Salary = 1234.12;
            obj1.City = "Hyderabad";

            var obj2 = new Employee();
            obj2.Eno = 1002;
            obj2.Ename = "BBB";
            obj2.Salary = 4321.12;
            obj2.City = "Secunderabad";

            data.Add(obj1);
            data.Add(obj2);

            TempData["info"] = data;

            return View();
        }


        public class Employee
        {
            public int Eno { get; set; }
            public string Ename { get; set; }
            public double Salary { get; set; }
            public string City { get; set; }
        }

    }
}
