using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity;
using Service;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        private ICategoryService categoryService;
        public HomeController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }


        [HttpPost]
        public JsonResult Create(CategoryModel model)//FormCollection collection
        {
            try
            {
                var category = new Category();
                category.Name = model.Name;

                categoryService.Insert(category);

                return Json("done", JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public JsonResult Ping()
        {
            var output = new Category();
            return Json(output, JsonRequestBehavior.AllowGet);
        }
    }
}
