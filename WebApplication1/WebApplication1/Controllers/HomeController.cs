using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
/*    [Authorize]*/
    public class HomeController : Controller
    {
        private IEmployeeReponsitory employeeReponsitory;
        private IWebHostEnvironment webHostEnvironment;
     
        public HomeController(IEmployeeReponsitory employeeReponsitory, IWebHostEnvironment webHostEnvironment)
        {
            this.employeeReponsitory = employeeReponsitory;
            this.webHostEnvironment = webHostEnvironment;
        }
        [Route("~/")]
        [Route("Home")]
        [Route("Home/Index")]
        [AllowAnonymous]
        public ViewResult Index()
        {
           // ViewData["employees"] = employeeReponsitory.Gets();
            ViewBag.employees = employeeReponsitory.Gets();
           
            return View();
        }
        public ViewResult Details(int? id)
        {
            try
            {
                int.Parse(id.Value.ToString());
                var emp = employeeReponsitory.Get(id.Value);
                if (emp == null)
                {
                    return View("~/Views/Error/EmployeeNotFound.cshtml");
                }
                var detalViewModel = new HomeDetailViewModel()
                {
                    employee = employeeReponsitory.Get(id ?? 1),
                    Titlename = "Employee Detail"

                };
                return View(detalViewModel);
            } catch(Exception e)
            {
                throw e;
            }
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(HomeCreateViewModel e)
        {
            if(ModelState.IsValid)
            {
                var newEmp = new Employee()
                {
                    Name = e.Name,
                    FullName = e.FullName,
                    Email = e.Email,
                    Department = e.Department,
                    DOB = e.DOB
                };
                var fileName = string.Empty;
                if (e.AvatarPath!=null)
                {
                    string uploadImg = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_{e.AvatarPath.FileName}" ;
                    var filePath = Path.Combine(uploadImg, fileName);
                    using(var fs = new FileStream(filePath,FileMode.Create))
                    {
                        e.AvatarPath.CopyTo(fs);
                    }    
                }
                newEmp.Avatar = fileName;
                var newE = employeeReponsitory.Create(newEmp);
                return RedirectToAction("Details", new { id = newE.id });
            }
            return View();
        }
     

        public ViewResult Edit(int id)
        {
            var employee = employeeReponsitory.Get(id);
            if(employee== null)
            {
                return View("~/View/Error/EmployeeNotFound", id);
            }
            var empEdit = new HomeEditViewModel()
            {
                avatarPath = employee.Avatar,
                Name = employee.Name,
                FullName = employee.FullName,
                Department = employee.Department,
                DOB = employee.DOB,
                Age = employee.Age,
                Email = employee.Email,
                id = employee.id
            };
            return View(empEdit);
        }
        [HttpPost]
        public IActionResult Edit(HomeEditViewModel e)
        {
            if(ModelState.IsValid)
            {
                var newEmp = new Employee()
                {
                    Name = e.Name,
                    FullName = e.FullName,
                    Email = e.Email,
                    Department = e.Department,
                    DOB = e.DOB,
                    id = e.id,
                };
                var fileName = string.Empty;
                if (e.AvatarPath != null)
                {
                    string uploadImg = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_{e.AvatarPath.FileName}";
                    var filePath = Path.Combine(uploadImg, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        e.AvatarPath.CopyTo(fs);
                    }
                    newEmp.Avatar = fileName;  
                    if(!string.IsNullOrEmpty(e.avatarPath))
                    {
                        string delFile = Path.Combine(webHostEnvironment.WebRootPath, "images", e.avatarPath);
                        System.IO.File.Delete(delFile);
                    }
                } else
                {
                    newEmp.Avatar = e.avatarPath;
                }
             
                if (employeeReponsitory.Edit(newEmp) != null)
                {
                    return RedirectToAction("Details", new { id = newEmp.id });
                }
            }    
      
                return View();
        }
     
        [HttpPost]
       
        public IActionResult Delete(int id)
        {
            if (employeeReponsitory.Delete(id))
                return RedirectToAction("Index");
                    return View();
        }
    }
}
