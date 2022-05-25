using ADO_Dropdown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADO_Dropdown.Controllers
{
    public class CascadingController : Controller
    {
        CascadingDDL obj = new CascadingDDL();
        // GET: Cascading
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetCountry()
        {
            var countries = obj.GetCountries();
            return Json(countries, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetState(int id)
        {
            var state = obj.GetState(id);
            return Json(state, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCity(int id)
        {
            var cities = obj.GetCity(id);
            return Json(cities, JsonRequestBehavior.AllowGet);
        }
    }
}