﻿using MyPortfolio_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio_MVC.Controllers
{
    [AllowAnonymous]//herkes erişebilir [Autorize] tersi
    public class DefaultController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult DefaultBanner()
        {
            var values = db.TblBanners.Where(x => x.IsShown == true).ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultExpertise()
        {
            var values = db.TblExpertises.ToList();

            return PartialView(values);
        }
        public PartialViewResult DefaultExperience()
        {
            var values = db.TblExperiences.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultEducation()
        {
            var values = db.TblEducations.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultProjects()
        {
            var values = db.TblProjects.ToList();
            return PartialView(values);
        }
        


    }
}