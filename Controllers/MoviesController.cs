using Microsoft.AspNetCore.Mvc;
using KasuleMoviesApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace KasuleMoviesApp.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index(int? year)
        {
            var movies = new List<Movie>
            {
                new Movie { Title = "Inception", Year = 2010 },
                new Movie { Title = "The Dark Knight", Year = 2008 },
                new Movie { Title = "The Matrix", Year = 1999 },
                new Movie { Title = "Interstellar", Year = 2014 },
                new Movie { Title = "The Prestige", Year = 2006 }
            };

            if (year.HasValue)
            {
                movies = movies.Where(m => m.Year >= year.Value).ToList();
            }

            return View(movies);
        }
    }
}
