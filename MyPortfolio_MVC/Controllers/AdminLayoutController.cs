using MyPortfolio_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio_MVC.Controllers
{
    public class AdminLayoutController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        // GET: AdminLayout
        public ActionResult Layout()
        {
            return View();
        }
        public PartialViewResult AdminLayoutHead()
        {
            return PartialView();
        }
        public PartialViewResult AdminLayoutSpinner()
        {
            return PartialView();
        }
        public PartialViewResult AdminLayoutSidebar()
        {
            var email = Session["email"].ToString();

            var admin = db.TblAdmins.FirstOrDefault(x => x.Email == email);

            ViewBag.namSurname = admin.Name + " " + admin.Surname;
            ViewBag.image = admin.ImageUrl;
            return PartialView();

            return PartialView();
        }
        public PartialViewResult AdminLayoutNavbar()
        {
            var email = Session["email"].ToString();
            
            var admin = db.TblAdmins.FirstOrDefault(x => x.Email == email);

            ViewBag.namSurname = admin.Name + " " + admin.Surname;
            ViewBag.image = admin.ImageUrl;
            return PartialView();


        }
        public PartialViewResult AdminLayoutFooter()
        {
            return PartialView();


        }
        public PartialViewResult AdminLayoutScripts()
        {
            return PartialView();


        }
    }
}