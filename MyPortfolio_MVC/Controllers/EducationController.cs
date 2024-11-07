﻿using MyPortfolio_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio_MVC.Controllers
{
    public class EducationController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var educations = db.TblEducations.ToList();
            return View(educations);
        }
        public ActionResult DeleteEducation(int id)
        {
            var deleteValue = db.TblEducations.Find(id);

            db.TblEducations.Remove(deleteValue);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}