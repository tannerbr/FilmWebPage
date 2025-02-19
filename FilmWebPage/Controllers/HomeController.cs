using System.Diagnostics;
using Mission06_Briggs.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.EntityFrameworkCore;

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
            ViewBag.Categories = _context.Categories

                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("MovieEntry", new Movies());
        }

        [HttpPost]
        public IActionResult MovieEntry(Movies response)
        {
            if (ModelState .IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.CategoryName)
                    .ToList();

                return View(response);
            }
        }
          

        public IActionResult MovieList()
        {
            var newMovies = _context.Movies
                .Include(x => x.Categories)
                .OrderBy(x => x.Title).ToList();

            return View(newMovies);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Majors = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("Movies", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movies updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("FilmList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movies film)
        {
            _context.Movies.Remove(film);
            _context.SaveChanges();
            return RedirectToAction("FilmList");
        }

        public IActionResult KnowJoel()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
