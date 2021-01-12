using FindRBeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FindRBeta.Controllers
{
    public class AdController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Ad
        [HttpGet]
        public ActionResult Index()
        {
            List<Ad> ads = db.Ads.ToList();
            ViewBag.Ads = ads;

            return View();
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if(id.HasValue)
            {
                Ad ad = db.Ads.Find(id);
                if(ad != null)
                {
                    return View(ad);
                }
                return HttpNotFound($"Couldn't find the ad with the id {id}!");
            }
            return HttpNotFound("Missing id parameter!");
        }

        [HttpGet]
        public ActionResult New()
        {
            Ad ad = new Ad();

            return View(ad);
        }

        [HttpPost]
        public ActionResult New(Ad adRequest)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    db.Ads.Add(adRequest);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(adRequest);
            }
            catch(Exception)
            {
                return View(adRequest);
            }
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if(id.HasValue)
            {
                Ad ad = db.Ads.Find(id);

                if(ad == null)
                {
                    return HttpNotFound($"Couldn't find the ad with id {id}!");
                }
                return View(ad);
            }
            return HttpNotFound("Missing id paramter!");
        }

        [HttpPut]
        public ActionResult Edit(int id, Ad adRequest)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    Ad ad = db.Ads.SingleOrDefault(a => a.AdId.Equals(id));

                    if(TryUpdateModel(ad))
                    {
                        ad.ProfileId = adRequest.ProfileId;
                        ad.Housing = adRequest.Housing;
                        ad.HousingYear = adRequest.HousingYear;
                        ad.HousingMonth = adRequest.HousingMonth;
                        ad.HousingDay = adRequest.HousingDay;
                        db.SaveChanges();
                    }
                    return RedirectToAction("Index");
                }
                return View(adRequest);
            }
            catch(Exception)
            {
                return View(adRequest);
            }
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            Ad ad = db.Ads.Find(id);
            if(ad != null)
            {
                db.Ads.Remove(ad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return HttpNotFound($"Couldn't find the ad with id {id}!");
        }
    }
}