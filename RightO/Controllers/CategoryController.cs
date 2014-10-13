using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RightO.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Category/

        public ActionResult Index(string subCategoryName)
        {
            ViewBag.SubCatName = subCategoryName;

            //create base model object here and pass it to view and render partial view accordingly
            return View();
        }

    }
}
