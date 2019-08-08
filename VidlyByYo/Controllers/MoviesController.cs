using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyByYo.Models;


namespace VidlyByYo.Controllers
{
    public class MoviesController : Controller
    {

        public ViewResult Index() {
            var movie = GetMovies();
            return View(movie);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1 , Name = "Shrek"},
                new Movie {Id = 2 , Name = "Wall-e"},
                new Movie {Id = 3 , Name = "Irom-Man"},
                new Movie {Id = 4 , Name = "Hulk"}
            };
        }        
        

    }
}