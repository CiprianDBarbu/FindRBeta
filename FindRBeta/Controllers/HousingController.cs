using FindRBeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FindRBeta.Controllers
{
    public class HousingController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Housing
        [HttpGet]
        public ActionResult Index()
        {
            List<Housing> housings = db.Housings.ToList();
            ViewBag.Housings = housings;

            return View();
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if(id.HasValue)
            {
                Housing housing = db.Housings.Find(id);
                if(housing != null)
                {
                    return View(housing);
                }
                return HttpNotFound($"Couldn't find the housing with id {id}!");
            }
            return HttpNotFound("Missing housing id paramter!");
        }

        [HttpGet]
        public ActionResult New()
        {
            Housing housing = new Housing
            {
                LocationsList = GetAllLocations()
            };

            return View(housing);
        }


        [HttpPost]
        public ActionResult New(Housing housingRequest)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    db.Housings.Add(housingRequest);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(housingRequest);
            }
            catch(Exception)
            {
                return View(housingRequest);
            }
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if(id.HasValue)
            {
                Housing housing = db.Housings.Find(id);

                if(housing == null)
                {
                    return HttpNotFound($"Couldn't find the housing with id {id}!");
                }
                housing.LocationsList = GetAllLocations();
                return View(housing);
            }
            return HttpNotFound("Missing id paramter!");
        }

        [HttpPut]
        public ActionResult Edit(int id, Housing housingRequest)
        {
            try
            {
                housingRequest.LocationsList = GetAllLocations();
                if(ModelState.IsValid)
                {
                    Housing housing = db.Housings.SingleOrDefault(h => h.HousingId.Equals(id));
                
                    if(TryUpdateModel(housing))
                    {
                        housing.Link = housingRequest.Link;
                        housing.Price = housingRequest.Price;
                        housing.NoOfRooms = housingRequest.NoOfRooms;
                        housing.LocationId = housingRequest.LocationId;
                        db.SaveChanges();
                    }
                    return RedirectToAction("Index");
                }
                return View(housingRequest);
            }
            catch (Exception)
            {
                return View(housingRequest);
            }
        }


        [HttpDelete]
        public ActionResult Delete(int id)
        {
            Housing housing = db.Housings.Find(id);
            if (housing != null)
            {
                db.Housings.Remove(housing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return HttpNotFound($"Couldn't find the housing with id {id}!");
        }

        [NonAction]
        public IEnumerable<SelectListItem> GetAllLocations()
        {
            var selectList = new List<SelectListItem>();

            foreach (var location in db.Locations.ToList())
            {
                selectList.Add(new SelectListItem
                {
                    Value = location.LocationId.ToString(),
                    Text = $"{location.Country}, {location.City}, {location.Placement}"
                });
            }

            return selectList;
        }
    }
}