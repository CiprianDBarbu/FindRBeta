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

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if(id.HasValue)
            {
                Location location = db.Locations.Find(id);
                if(location != null)
                {
                    return View(location);
                }
                return HttpNotFound("The location does not exist!");
            }
            return HttpNotFound("Missing location id parameter!");
        }

        [HttpGet]
        public ActionResult New()
        {
            Location location = new Location();

            return View(location);
        }

        [HttpPost]
        public ActionResult New(Location locationRequest)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    db.Locations.Add(locationRequest);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(locationRequest);
            }
            catch(Exception)
            {
                return View(locationRequest);
            }
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if(id.HasValue)
            {
                Location location = db.Locations.Find(id);

                if(location == null)
                {
                    return HttpNotFound("Couldn't find this location!");
                }
                return View(location);
            }
            return HttpNotFound("Missing id paramter!");
        }

        [HttpPut]
        public ActionResult Edit(int id, Location locationRequest)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    Location location = db.Locations.SingleOrDefault(l => l.LocationId.Equals(id));

                    if(TryUpdateModel(location))
                    {
                        location.Country = locationRequest.Country;
                        location.City = locationRequest.City;
                        location.Placement = locationRequest.Placement;
                        db.SaveChanges();
                    }
                    return RedirectToAction("Index");
                }
                return View(locationRequest);
            }
            catch(Exception)
            {
                return View(locationRequest);
            }
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            Location location = db.Locations.Find(id);
            if(location != null)
            {
                db.Locations.Remove(location);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return HttpNotFound($"Couldn't find the location with id{id}");
        }

    }
}