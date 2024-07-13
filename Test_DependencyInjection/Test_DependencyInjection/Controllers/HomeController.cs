using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Test_DependencyInjection.Models;
using Test_DependencyInjection.Services;

namespace Test_DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailSenderService _service;

        public HomeController(IEmailSenderService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            _service.SendEmail("Hello World");
            return View();
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
