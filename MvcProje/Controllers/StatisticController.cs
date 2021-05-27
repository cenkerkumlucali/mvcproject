using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess.Concrete;

namespace MvcProje.Controllers
{
    public class StatisticController : Controller
    {
        private Context context = new Context();
        // GET: Statistic
        public ActionResult Index()
        {
            var totalCategory = context.Categories.Count();
            ViewBag.totalCategories = totalCategory;

            var getSoftwareCategory = context.Headings.Count(c => c.CategoryId == 6);
            ViewBag.getSoftwareCategories = getSoftwareCategory;

            var checkWriterNameForA = context.Writers.Count(x => x.WriterName.Contains("a"));
            ViewBag.checkWriterNameForA = checkWriterNameForA;

            var mostTitles = context.Headings.Max(x => x.Category.CategoryName);
            ViewBag.mostTitles = mostTitles;

            var categoryStatusTrue = context.Categories.Count(x => x.CategoryStatus == true); 
            ViewBag.activeCategories = categoryStatusTrue;
            return View();
        }
    }
}