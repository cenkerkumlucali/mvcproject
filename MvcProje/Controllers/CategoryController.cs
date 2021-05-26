using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;

namespace MvcProje.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult GetCategoryList()
        {
            var categoryValues = categoryManager.GetList();
            return View(categoryValues);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(category);
            if (results.IsValid)
            {
                categoryManager.CategoryAdd(category);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var result in results.Errors)
                {
                    ModelState.AddModelError(result.PropertyName,result.ErrorMessage);
                }
            }

            return View();
        }
    }
}