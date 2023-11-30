using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWeb.Models;
using MyWeb.Repositories;

namespace MyWeb.Controllers
{
    [Authorize]

    public class StudentsController : Controller
    {
        private readonly ILogger<StudentsController> _logger;
        private readonly IStudentRepository _studentRepository;

        public StudentsController(ILogger<StudentsController> logger, IStudentRepository studentRepository)
        {
            _logger = logger;
            _studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            ViewData["Date"] = DateTime.Now;
            ViewData["Title"] = "student List";
            var models = _studentRepository.GetAll();
            return View(models);
        }

        public IActionResult Description()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}