using MyPortfolio_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio_MVC.Controllers
{
    public class ProjectController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        // GET: Project

        private void CategoryDDropDown()
        {
            var categoryList = db.TblCategories.ToList();

            List<SelectListItem> categories = (from x in categoryList
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();

            ViewBag.categories = categories;
        }

        public ActionResult Index()
        {
            var projects = db.TblProjects.ToList();

            return View(projects);


        }//IList IEnumerable ICollection List
        [HttpGet]
        public ActionResult CreateProject()
        {
            CategoryDDropDown();

            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(TblProject model)
        {
            CategoryDDropDown();

            if ((!ModelState.IsValid))
            {
                return View(model);
            }
            {
                
            }
            db.TblProjects.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

       public ActionResult DeleteProject(int id)
        {
            var value = db.TblProjects.Find(id);
            db.TblProjects.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            CategoryDDropDown();
            var value = db.TblProjects.Find(id);
            return View(value);

        }
        [HttpPost]
        public ActionResult UpdateProject(TblProject model)
        {
            CategoryDDropDown();
            var value = db.TblProjects.Find(model.ProjectId);
            value.Name = model.Name;
            value.ImageUrl = model.ImageUrl;
            value.Description = model.Description;
            value.CategoryID = model.CategoryID;
            value.GithubUrl = model.GithubUrl;
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}