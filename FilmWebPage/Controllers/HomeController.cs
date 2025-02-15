using System.Diagnostics;
using Mission06_Briggs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mission06_Briggs.Controllers
{
    public class HomeController : Controller
    {
        private readonly FilmContext _context;

        public HomeController(FilmContext tempName)
        {
            _context = tempName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieEntry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieEntry(FilmCollection response)
        {

            _context.FilmCollections.Add(response);
            _context.SaveChanges();

            return View("Confirmation", response);
        }
          

        public IActionResult KnowJoel()
        {
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
