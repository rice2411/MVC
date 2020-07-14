using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cinema.Models;
using Microsoft.AspNetCore.Hosting;
using Cinema.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Cinema.Controllers
{
    public class HomeController : Controller
    {
        private IFilmRepository filmRepository;
        private IWebHostEnvironment webHostEnvironment;
        private readonly SignInManager<IdentityUser> signInManager;
        public HomeController(IFilmRepository filmRepository, IWebHostEnvironment webHostEnvironment, SignInManager<IdentityUser> signInManager)
        {
            this.filmRepository = filmRepository;
            this.webHostEnvironment = webHostEnvironment;
            this.signInManager = signInManager;
        }
        [AllowAnonymous]
        public ViewResult Index()
        {
       
            ViewBag.films = filmRepository.Gets();
        
            return View();
        }
        [AllowAnonymous]
        public ViewResult Detail(string id)
        {
            var film = filmRepository.Get(id);
            var detailFilm = new HomeDetailsViewModel()
            {
                filmName = film.filmName,
                filmPoster = film.filmPoster,
                filmId = film.filmId,
                filmDescription = film.filmDescription,
                timeOfFilm = film.timeOfFilm
            };
            return View(detailFilm);
        }
     
        public ViewResult Book(string id)
        {
            var film = filmRepository.Get(id);
            var bookFilm = new HomeBookViewmodel()
            {
                filmName = film.filmName,
                filmPoster = film.filmPoster,
                timeOfFilm = film.timeOfFilm
            };
            return View(bookFilm);
        }
    }
}
