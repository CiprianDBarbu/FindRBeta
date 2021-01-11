﻿using FindRBeta.Models;
using FindRBeta.Models.DataBaseInitializer;
using Microsoft.AspNet.Identity;
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


        [HttpGet]
        public ActionResult Details(int? id)
        {
            if(id.HasValue)
            {
                Profile profile = db.Profiles.Find(id);
                if(profile != null)
                {
                    return View(profile);
                }
                return HttpNotFound("User does not exist!");
            }
            return HttpNotFound("Missing search details!");
        }

        [HttpGet]
        public ActionResult New()
        {
            Profile profile = new Profile 
            {
                LocationsList = GetAllLocations()
            };
            return View(profile);
        }

        [HttpPost]
        public ActionResult New(Profile profileRequest)
        {
            try
            {
                if(ModelState.IsValid && profileRequest.ApplicationUserId == null)
                {
                    profileRequest.ApplicationUserId = User.Identity.GetUserId();
                    db.Profiles.Add(profileRequest);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(profileRequest);
            }
            catch (Exception)
            {
                return View(profileRequest);
            }
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if(id.HasValue)
            {
                Profile profile = db.Profiles.Find(id);

                if(profile == null)
                {
                    return HttpNotFound("User does not exist!");
                }
                profile.LocationsList = GetAllLocations();
                return View(profile);
            }
            return HttpNotFound("Missing id parameter!");
        }

        [HttpPut]
        public ActionResult Edit(int id, Profile profileRequest)
        {
            try
            {
                profileRequest.LocationsList = GetAllLocations();
                if(ModelState.IsValid)
                {
                    Profile profile = db.Profiles.SingleOrDefault(p => p.ProfileId.Equals(id));

                    if(TryUpdateModel(profile))
                    {
                        profile.Age = profileRequest.Age;
                        profile.GenderType = profileRequest.GenderType;
                        profile.Address = profileRequest.Address;
                        profile.Details = profileRequest.Details;
                        db.SaveChanges();
                    }
                    return RedirectToAction("Index");
                }
                return View(profileRequest);
            }
            catch (Exception)
            {
                return View(profileRequest);
            }
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            Profile profile = db.Profiles.Find(id);
            if(profile != null)
            {
                db.Profiles.Remove(profile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return HttpNotFound($"Couldn't find the user with id {id}!");
        }


        //[NonAction]
        //public IEnumerable<SelectListItem> GetAllGenderTypes()
        //{
        //    var selectList = new List<SelectListItem>();

        //    selectList.Add(new SelectListItem
        //    {
        //        Value = Gender.Male.ToString(),
        //        Text = "Male"
        //    });

        //    selectList.Add(new SelectListItem
        //    {
        //        Value = Gender.Female.ToString(),
        //        Text = "Female"
        //    });

        //    selectList.Add(new SelectListItem
        //    {
        //        Value = Gender.Others.ToString(),
        //        Text = "Others"
        //    });

        //    return selectList;
        //}

        [NonAction]
        public IEnumerable<SelectListItem> GetAllLocations()
        {
            var selectList = new List<SelectListItem>();

            foreach(var location in db.Locations.ToList())
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