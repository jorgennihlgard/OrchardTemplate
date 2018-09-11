using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//namespace PD.TreeViewMenu.Controllers
//{
//    public class TreeViewController : Controller
//    {
//        // GET: TreeView
//        public ActionResult Index()
//        {
//            return View();
//        }

//        public JsonResult Employees(int? id)
//        {
//            //var dataContext = new SampleEntities();

//            var employees = new { { "id":"1"} { Name: "Mats"}; { "hasChildren": "false"} };
//            //var employees = from e in dataContext.Employees
//            //                where (id.HasValue ? e.ReportsTo == id : e.ReportsTo == null)
//            //                select new
//            //                {
//            //                    id = e.EmployeeID,
//            //                    Name = e.FirstName + " " + e.LastName,
//            //                    hasChildren = e.Employees1.Any()
//            //                };

//            return Json(employees, JsonRequestBehavior.AllowGet);
//        }
//    }
//}