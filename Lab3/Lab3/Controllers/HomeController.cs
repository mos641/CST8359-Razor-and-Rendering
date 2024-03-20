using Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SongForm() => View();

        // 6. Action Sing in HomeController, must store the number of buttles in session or ViewData/ViewBag
        // 7. Action Sing in HomeController, will call the view ‘Sing’ with the number of buttles still stored in session or ViewData/ViewBag
        [HttpPost]
        public IActionResult Sing()
        {
            ViewData["bottles"] = Request.Form["bottles"];
            return View();
        }
        
        public IActionResult CreatePerson() => View();
        
        [HttpPost]
        public IActionResult DisplayPerson(Person person)
        {
            // you will complete this
            return View(person);
        }
        
        public IActionResult Error()
        {
            return View();
        }
    }
}
