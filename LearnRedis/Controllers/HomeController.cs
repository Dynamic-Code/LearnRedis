using LearnRedis.Data;
using LearnRedis.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LearnRedis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext dataContext;

        public HomeController(ILogger<HomeController> logger, DataContext dataContext)
        {
            _logger = logger;
            this.dataContext = dataContext;
        }

        public IActionResult Index()
        {
            List<Employee> EmployeeList = new();
            var cachedEmployee = "";
            if(!String.IsNullOrEmpty(cachedEmployee))
            {

            }
            else
            {
                EmployeeList = dataContext.Employees.ToList();
            }
            return View(EmployeeList);
        }

        public IActionResult Privacy()
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