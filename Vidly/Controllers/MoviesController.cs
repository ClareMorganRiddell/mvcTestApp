using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            { pageIndex = 1; }
            if (String.IsNullOrWhiteSpace(sortBy))
            { sortBy = "Name"; }

            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }


        public ActionResult Random()
        {
            var movie = new Movie() { Name = "True Romance" };

            var customers = new List<Customer>
            {
                new Customer {Name = "Sam"},
                new Customer {Name = "Jon"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult AllMovies()
        {
            var movies = new List<Movie>
            {
                new Movie { Name = "True Romance" },
                new Movie { Name = "Willow" },
                new Movie { Name = "Princess Bride" },
                new Movie { Name = "Your Royal Highness" }
            };

            var viewModel = new MovieViewModel
            {
                Movies = movies
            };

            return View(viewModel);

        }
    }
}