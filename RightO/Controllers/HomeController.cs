using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RightO.DAL;
using RightO.Mailers;
using RightO.Models;

namespace RightO.Controllers
{
    public class HomeController : Controller
    {
        private ICategoryRepository _categoryRepository;
        private ISubCategoryRepository _subCategoryRepository;
        private ICustomerRepository _customerRepository;
        private IProRepository _proRepository;
        private IWorkLocationsRepository _workLocationsRepository;
        private IWorkTimingsRepository _workTimingsRepository;
        private ITestimonialRepository _testimonialRepository;
        private IUserMailer _userMailer = new UserMailer();
        public IUserMailer UserMailer
        {
            get { return _userMailer; }
            set { _userMailer = value; }
        }

        public HomeController() 
        {
            this._categoryRepository = new CategoryRepository(new RightOEntities());
            this._subCategoryRepository = new SubCategoryRepository(new RightOEntities());
            this._customerRepository = new CustomerRepository(new RightOEntities());
            this._proRepository = new ProRepository(new RightOEntities());
            this._workLocationsRepository = new WorkLocationsRepository(new RightOEntities());
            this._workTimingsRepository = new WorkTimingsRepository(new RightOEntities());
            this._testimonialRepository = new TestimonialRepository(new RightOEntities());

        }

        public HomeController(ICategoryRepository catRepository, ISubCategoryRepository subRespository, ICustomerRepository cusRepository,
            IProRepository proRepos, IWorkLocationsRepository worklocationRepos, IWorkTimingsRepository workTimingsRepository, ITestimonialRepository testimonialRepository)
        {
            _categoryRepository = catRepository;
            _subCategoryRepository = subRespository;
            _customerRepository = cusRepository;
            _proRepository = proRepos;
            _workLocationsRepository = worklocationRepos;
            _workTimingsRepository = workTimingsRepository;
            _testimonialRepository = testimonialRepository;
        }

        public ActionResult Index()
        {
            ViewBag.WorkLocations = _workLocationsRepository.GetWorkLocations();
            ViewBag.WorkTimings = _workTimingsRepository.GetWorkTimings();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetSubCategories()
        {
            var subCategories = _subCategoryRepository.GetAllSubCategories();
            List<SubCategoryMaster> jsonSUbCategories = subCategories.Where(l => l.CategoryMaster.IsAvailable == true).ToList();
            var jsonToReturn = jsonSUbCategories.Select(x => new
            {
                categoryId = x.CategoryID,
                categoryName = x.CategoryMaster.CategoryName,
                isAvailable = x.CategoryMaster.IsAvailable,
                subCategoryName = x.SubCategoryName,
                subcategoryId = x.SubCategoryID
            });
            return this.Json(jsonToReturn, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetTestimonials()
        {
            var testimonials = _testimonialRepository.GetAllTestimonials().OrderBy(s => Guid.NewGuid()).Take(2);
            var jsonToReturn = testimonials.Select(x => new
            {
                testimonialInfo = x.TestimonialInfo,
                username = x.CustomerUserMaster.Name.ToUpper()
            });
            return this.Json(jsonToReturn, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SendContactEnquiry(ContactModel contactModel)
        {

            _userMailer.Welcome("test mail", "piyushraw12@gmail.com", contactModel).Send(); ;
            return this.Json(new { success = true});
        }
    }
}
