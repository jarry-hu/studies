using AspDotNetCore.DataRepositories;
using AspDotNetCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public ViewResult Index()
        {
            var model = _studentRepository.GetStudent(1);
            return View("Test",model);
        }

        public ViewResult Details()
        {
            //var model = _studentRepository.GetAllStudents();
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Student = _studentRepository.GetAllStudents(),
                PageTitle = "Student Details"
            };
            // ViewBag.PageTitle = "学生详细";
            // ViewData["PageTitle"] = "Student Details";
            // ViewData["Student"] = model;
            return View(homeDetailsViewModel);
        }
    }
}
