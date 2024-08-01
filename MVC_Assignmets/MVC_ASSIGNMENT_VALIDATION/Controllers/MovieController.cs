using Microsoft.AspNetCore.Mvc;
using HandsOnModels.Models;

namespace HandsOnModels.Controllers
{
    public class MovieController : Controller
    {
        MovieRepository movieRepository;

        public MovieController()
        {
            movieRepository = new MovieRepository();
        }

        public IActionResult Index()
        {
            var movies = movieRepository.GetAllMovies();
            return View(movies);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                movieRepository.AddMovie(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        public IActionResult Details(string name)
        {
            var movie = movieRepository.GetMovieByName(name);
           
            return View(movie);
        }
    }
}
