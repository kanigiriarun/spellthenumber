using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpelltheNumber.Models;
using SpelltheNumberAdapter;

namespace SpelltheNumber.Controllers
{
    public class HomeController : Controller
    {
        private readonly NumberToWords _numberToWords;

        public HomeController(NumberToWords numberToWords)
        {
            _numberToWords = numberToWords;
        }
        public IActionResult Index(string q)
        {
            var result = _numberToWords.changeNumericToWords(q);
            ViewData["Result"] = result;
            return View();
        }

        public IActionResult About(string q)
        {
            ViewData["Message"] = "Your application description page.";
            var result = _numberToWords.changeNumericToWords(q);
            ViewData["Result"] = result;
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
