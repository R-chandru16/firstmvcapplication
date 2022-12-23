using FirstMVCApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApplication.Controllers
{
    public class StudentController : Controller
    {
        static List<Student> students = new List<Student>();
        public IActionResult Index()
        {

            //Action

            //int[] score = { 100, 89, 97 };
            //ViewBag.Name = "Tim";
            //ViewData["Username"] = "userTim";
            //ViewBag.Scores = score;
            //ViewData["Scores"] = score;
            //return View();

            //Student student = new Student();
            //student.Id = 101;
            //student.Name = "tim ";
            //student.Age = 21;
            //ViewBag.student = student;
            //return View(student);
            return View(students);

        }
        [HttpGet] //Helpfull for getting input 
        public IActionResult Create() // right click - view-RazorView-create.cshtml created
        {
            return View();
        }
  
        [HttpPost] //Helpfull for post the output
        public IActionResult Create(Student student)
        {
            students.Add(student);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            return View(id);
        }
    }
}
