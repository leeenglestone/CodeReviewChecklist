using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CodeReviewChecklist.CoreMvcWebApplication.Models;

namespace CodeReviewChecklist.CoreMvcWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Code Review Checklist";
            ViewBag.MetaDescription = "What is a Code Review Checklist and why might you benefit from one?";
            ViewBag.Canonical = "https://www.codereviewchecklist.com/";
            ViewBag.Image = "https://www.codereviewchecklist.com/images/code-review-checklist.png";

            return View();
        }

        [Route("/about/")]
        public IActionResult About()
        {
            ViewBag.Title = "About Code Review Checklist";
            ViewBag.MetaDescription = "Why was Code Review Checklist created any by whom?";
            ViewBag.Canonical = "https://www.codereviewchecklist.com/about/";
            ViewBag.Image = "https://www.codereviewchecklist.com/images/code-review-checklist.png";

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
