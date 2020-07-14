using Cinema.Models;
using Cinema.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    public class FilmController : Controller
    {
        private IFilmRepository filmRepository;
        private IWebHostEnvironment webHostEnvironment;
  
        public FilmController(IFilmRepository filmRepository, IWebHostEnvironment webHostEnvironment)
        {
            this.filmRepository = filmRepository;
            this.webHostEnvironment = webHostEnvironment;
        
        }
        public IActionResult Index()
        {
            ViewBag.films = filmRepository.Gets();

            return View();
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(FilmCreateViewModel f)
        {
            if (ModelState.IsValid)
            {
                var newFilm = new Film()
                {
                    filmName = f.filmName,
                
                    timeOfFilm = f.timeOfFilm,
                    filmDescription = f.filmDescription,
                    filmId = $"{Guid.NewGuid()}"

                };
                var fileName = string.Empty;
                if (f.filmPoster != null)
                {
                    string uploadImg = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_{f.filmPoster.FileName}";
                    var filePath = Path.Combine(uploadImg, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        f.filmPoster.CopyTo(fs);
                    }
                }
                newFilm.filmPoster = fileName;
                var newF = filmRepository.Create(newFilm);
                return RedirectToAction("Detail", "Home", new { id = newF.filmId });
            }
            return View();
        }
        [HttpGet]
        public ViewResult Edit(string id)
        {
            var film = filmRepository.Get(id);

            var editFilm = new FilmEditViewModel()
            {
                filmId = film.filmId,
                FilmPoster = film.filmPoster,
                filmDescription = film.filmDescription,
                filmName = film.filmName,
                timeOfFilm = film.timeOfFilm
            };
            return View(editFilm);
        }
        [HttpPost]
        public IActionResult Edit(FilmEditViewModel f)
        {
            if (ModelState.IsValid)
            {
                var newFilm = new Film()
                {
                   filmId = f.filmId,
                   filmName = f.filmName,
                   filmDescription = f.filmDescription,
                   timeOfFilm = f.timeOfFilm
                };
                var fileName = string.Empty;
                if (f.filmPoster != null)
                {
                    string uploadImg = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_{f.filmPoster.FileName}";
                    var filePath = Path.Combine(uploadImg, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        f.filmPoster.CopyTo(fs);
                    }
                    newFilm.filmPoster = fileName;
                    if (!string.IsNullOrEmpty(f.FilmPoster))
                    {
                        string delFile = Path.Combine(webHostEnvironment.WebRootPath, "images", f.FilmPoster);
                        System.IO.File.Delete(delFile);
                    }
                }
                else
                {
                    newFilm.filmPoster = f.FilmPoster;
                }

                if (filmRepository.Edit(newFilm) != null)
                {
                    return RedirectToAction("Detail","Home", new { id = newFilm.filmId });
                }
            }

            return View();
        }
        [HttpPost]

        public IActionResult Delete(FilmEditViewModel f)
        {
            if (filmRepository.Delete(f.filmId))
                return RedirectToAction("Index","Film");
            return RedirectToAction("Index", "Film");
        }
    }
}
