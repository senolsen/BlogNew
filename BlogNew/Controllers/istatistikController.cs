using Business.concrete;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogNew.Controllers
{
    public class istatistikController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        ArticleManager am = new ArticleManager(new EfArticleDal());
        WriterManager wm = new WriterManager(new EFWriterDal());
        // GET: istatistik
        public ActionResult Index()
        {
            ViewBag.ToplamKategori = cm.GetList().Count();
            ViewBag.ToplamYazilim = am.GetList().Where(x => x.CategoryId == 2).Count();
            ViewBag.ToplamYazar = wm.GetList().Where(x => x.WriterName.ToLower().Contains("a")).Count();
            var kategoriid = am.GetList().GroupBy(x => x.CategoryId).OrderByDescending(x => x.Count()).Select(z => z.Key).FirstOrDefault();
            ViewBag.MaxKategori = cm.GetByID(kategoriid).CategoryName.ToString();
            ViewBag.Kategorifark = (cm.GetList().Where(x => x.CategoryStatus == true).Count()) - (cm.GetList().Where(x => x.CategoryStatus == false).Count());

            return View();
        }
    }
}