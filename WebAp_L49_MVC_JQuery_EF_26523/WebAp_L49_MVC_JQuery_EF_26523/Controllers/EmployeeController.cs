using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAp_L49_MVC_JQuery_EF_26523.Models;
//using System.Data.Entity;

namespace WebAp_L49_MVC_JQuery_EF_26523.Controllers
{
    // Entity framework me procedure ka use only 2% hai
    public class EmployeeController : Controller
    {
        DatabaseContext _db = new DatabaseContext();
        public ActionResult Create()
        {
            return View();
        }

        //public void Insert(tblEmployee obj)
        //{
        //    _db.tblEmployees.Add(obj);
        //    _db.SaveChanges();
        //}

        public void InsertUpdate(tblEmployee obj)
        {
            if (obj.empid > 0)
            {
                //_db.Entry(obj).State = EntityState.Modified;
                //_db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                _db.sp_tblEmployee_update(obj.empid,obj.name,obj.address,obj.age);
            }
            else
            {
                //_db.tblEmployees.Add(obj);  // with Query/table
                _db.sp_tblEmployee_insert(obj.name,obj.address,obj.age);
            }
            _db.SaveChanges();
        }

        

        public JsonResult Get()
        {
            //var data = _db.tblEmployees.ToList();
            var data =  _db.sp_tblEmployee_get().ToList();
            return Json(data,JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAllCountry()
        {
            var data = _db.tblCountries.ToList();// by table name/ query
            //var data = (from a in _db.tblCountries select a).ToList();// by LINQ
            //var data = _db.sp_tblEmployee_get().ToList();// by  store procedure
            //var data = _db.usp_tblCountry_get().ToList();// by  store procedure
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        

        public void Delete(tblEmployee obj)
        {
            _db.sp_tblEmployee_delete(obj.empid);
            //var IDD = _db.tblEmployees.Find(obj.empid);
            //_db.tblEmployees.Remove(IDD);
            _db.SaveChanges();
        }

        public JsonResult Edit(tblEmployee obj)
        {
            //var data = (from a in _db.tblEmployees where a.empid == obj.empid select a).ToList();
            var data =  _db.sp_tblEmployee_edit(obj.empid);
            return Json(data,JsonRequestBehavior.AllowGet);
        }
    }
}