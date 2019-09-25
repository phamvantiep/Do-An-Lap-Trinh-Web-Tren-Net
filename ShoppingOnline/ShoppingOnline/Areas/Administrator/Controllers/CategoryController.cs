using ShoppingOnline.Model;
using ShoppingOnline.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingOnline.Areas.Administrator.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepo = new CategoryRepository();
        // GET: Administrator/Category
        public ActionResult Index()
        {
            return View(categoryRepo.GetAll());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    categoryRepo.Create(c);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(c);
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            Category c = categoryRepo.GetById(id);
            return View(c);
        }

        [HttpPost]
        public ActionResult Edit(Category c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    categoryRepo.Update(c);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(c);
        }

        public ActionResult Delete(string id)
        {
            try
            {
                categoryRepo.Delete(id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return RedirectToAction("Index");
        }
    }
}