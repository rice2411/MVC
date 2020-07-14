using Cinema.Models;
using Cinema.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    public class ScreeningController : Controller
    {
        private IScreeningRepository screeningRepository;
        private IWebHostEnvironment webHostEnvironment;
        private IFilmRepository filmRepository;
        private IRoomRepository roomRepository;
        public ScreeningController(IScreeningRepository screeningRepository, IWebHostEnvironment webHostEnvironment, IFilmRepository filmRepository, IRoomRepository roomRepository)
        {
            this.screeningRepository = screeningRepository;
            this.webHostEnvironment = webHostEnvironment;
            this.filmRepository = filmRepository;
            this.roomRepository = roomRepository;
        }
        public IActionResult Index()
        {
            ViewBag.screens = screeningRepository.Gets();

            return View();
        }
        [HttpGet]
        public ViewResult Create()
        {
            ViewBag.Films = filmRepository.Gets();
            ViewBag.Rooms = roomRepository.Gets();
            return View();
        }
        [HttpPost]
        public IActionResult Create(ScreeningCreateViewModel s)
        {
            if (ModelState.IsValid)
            {
                var newSC = new Screening()
                {
                    screeningID = $"{Guid.NewGuid()}",
                    filmId = s.filmId,
                    roomId= s.roomId,
                    timeStart = s.timeStart
                };
 
                screeningRepository.Create(newSC);
                
                return RedirectToAction("Index", "Screening");
            }
            return View();
        }
    }
}
