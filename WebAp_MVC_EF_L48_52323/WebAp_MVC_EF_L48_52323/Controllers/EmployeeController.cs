using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAp_MVC_EF_L48_52323.Models;

namespace WebAp_MVC_EF_L48_52323.Controllers
{
    public class EmployeeController : Controller
    {

        DatabaseContext _db = new DatabaseContext();
        tblEmployee _emp = new tblEmployee();
        public ActionResult Create()
        {
            return View();
        }

        public JsonResult Get()
        {
            var data = _db.tblEmployees.ToList();
            //var data = (from a in  _db.tblEmployees select a).ToList();// By Using LINQ
            return Json(data,JsonRequestBehavior.AllowGet);
        }
        public void Insert(tblEmployee obj)
        {
            _db.tblEmployees.Add(obj);
            _db.SaveChanges();
        }
    }
}