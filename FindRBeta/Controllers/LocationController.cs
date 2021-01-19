using FindRBeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FindRBeta.Controllers
{
    public class LocationController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        
        // GET: Location
        [HttpGet]
        [Authorize(Roles = "Admin, Editor")]
        public ActionResult Index()
        {
            List<Location> locations = db.Locations.ToList();
            ViewBag.Locations = locations;

            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Admin, Editor")]
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
        [Authorize(Roles = "Admin")]
        public ActionResult New()
        {
            Location location = new Location();

            return View(location);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
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