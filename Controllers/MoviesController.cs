using System.Collections.Generic;
using System.Linq;
using AspNetExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetExample.Controllers
{
    [Route("/movies")]
    public class MoviesController : Controller
    {
        public readonly List<Movie> Movies;

        public MoviesController(MovieContext context)
        {
            Movies = context.Movie.ToList();
        }

        public IActionResult Index()
        {
            ViewData["Movies"] = Movies;

            return View();
        }

        [Route("{id}")]
        public IActionResult Movie(string id)
        {
            if (Movies.All(movie => movie.Id != id)) return Redirect("/movies/");
            var first = Movies.First(movie => movie.Id == id);
            return View(first);
        }
    }
}