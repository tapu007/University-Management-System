using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using University.BLL.Contracts;
using University.Models.EntityModels;

namespace UniversityApp.Controllers
{
    public class GradePointController : Controller
    {
        private IGradePointManager _gradePointManager;
        public GradePointController(IGradePointManager gradePointManager)
        {
            _gradePointManager = gradePointManager;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(GradePoint gradePoint)
        {
            if (ModelState.IsValid)
            {
                bool isSaved = _gradePointManager.Add(gradePoint);
                if (isSaved)
                {
                    ViewBag.Message = "Saved Successfully..";
                }
            }
            return View();
        }
        public IActionResult Search()
        {
            var gradePoint = _gradePointManager.GetAll();
            return View(gradePoint);
        }
    }
}