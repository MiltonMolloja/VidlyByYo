using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyByYo.Models;
using System.Data.Entity;


namespace VidlyByYo.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        public ViewResult Index() {
            var movie = _context.Movies.Include(c => c.Genre).ToList();
            return View(movie);
        }

        public ActionResult Details(int id)
        {            
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);
            
            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }



    }
}