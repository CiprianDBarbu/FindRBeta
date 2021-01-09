using FindRBeta.Models;
using FindRBeta.Models.DataBaseInitializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindRBeta.Controllers
{
    public class ProfileController : Controller
    {

        private DbCtx db = new DbCtx();


        // GET: Profile
        [HttpGet]
        public ActionResult Index()
        {
            List<Profile> profiles = db.Profiles.ToList();
            ViewBag.Profiles = profiles;

            return View();
        }
    }
}