using Business.concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogNew.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            CategoryManager categoryManager = new CategoryManager();
            List<Category> categories = categoryManager.GetAll();
            var model = categories.ToList();
            return View(model);
        }
    }
}