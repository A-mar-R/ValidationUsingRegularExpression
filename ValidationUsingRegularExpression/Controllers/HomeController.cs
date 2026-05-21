using Microsoft.AspNetCore.Mvc;
using ValidationUsingRegularExpression.Models;

namespace ValidationUsingRegularExpression.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Employee emp)
        {
            if(!ModelState.IsValid)
            {
                return View(emp);
            }
            return View("Details", emp);
        }
    }
}
