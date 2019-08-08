﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyByYo.Models;
using VidlyByYo.ViewModels;

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
        
        
        public ActionResult Random()
        {
            var movie = new Movie() {Id = 1,  Name = "Shrek!!" };
            var customers = new List<Customer>
            {
                new Customer { Id = 1 , Name = "Customer 1"},
                new Customer { Id = 1 , Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

    }
}