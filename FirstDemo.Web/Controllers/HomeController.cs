using FirstDemo.Base.DbContexts;
using FirstDemo.Base.Entities;
using FirstDemo.Base.Repositories;
using FirstDemo.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstDemo.Web.Controllers
{
	public class HomeController : Controller
	{
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly ICourseRepository _courseRepository;

        public HomeController(ILogger<HomeController> logger,
            IConfiguration configuration,
            ICourseRepository courseRepository)
        {
            _logger = logger;
            _configuration = configuration;
            _courseRepository = courseRepository;
        }

        public IActionResult Index()
		{
			var model = new IndexModel();
			return View(model);
		}

		[HttpPost, ValidateAntiForgeryToken]
		public IActionResult Index(IndexModel model)
		{
			return View(model);
		}

		public IActionResult Add()
		{
			var model = new Course();
			model.Name = "MERN Stack";
			model.Fees = 4000;

            _courseRepository.Insert(model);
            //_baseDbContext.Add(model);
            //_courseRepository.Update(model);
            /*_courseRepository.Remove(model);*/ //Repository Pattern

            _courseRepository.Save(); //Unit of Work Pattern

            return View();
		}

		public IActionResult Update()
		{
			var model = new Course();
			model.Id = 1;
			model.Name = "C# For Beginners";
			model.Fees = 3000;

			//_courseRepository.Insert(model);
			//_courseRepository.Update(model);
			/*_courseRepository.Remove(model);*/ //Repository Pattern

			_courseRepository.Save(); //Unit of Work Pattern

            return View();
		}

		public IActionResult Remove()
		{
			var model = new Course();
			model.Id = 2;
			model.Name = "C# For Beginners";
			model.Fees = 3000;

			//_courseRepository.Insert(model);
			//_courseRepository.Update(model);
			//_courseRepository.Remove(model);

			_courseRepository.Save(); //Unit of Work Pattern

            return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult AboutUs()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}