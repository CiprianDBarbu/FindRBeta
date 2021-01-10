using FindRBeta.Models;
using FindRBeta.Models.DataBaseInitializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindRBeta.Controllers
{
    public class LocationController : Controller
    {

        private DbCtx db = new DbCtx();

        
        // GET: Location
        [HttpGet]
        public ActionResult Index()
        {
            List<Location> locations = db.Locations.ToList();
            ViewBag.Locations = locations;

            return View();
        }
    }
}