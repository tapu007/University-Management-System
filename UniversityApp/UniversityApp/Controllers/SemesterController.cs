using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using University.Models.EntityModels;
using University.Repositories.Contracts;

namespace UniversityApp.Controllers
{
    public class SemesterController : Controller
    {
        private ISemesterRepository _semesterRepository;
        public SemesterController(ISemesterRepository semesterRepository)
        {
            _semesterRepository = semesterRepository;

        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Semester semester)
        {
            if (ModelState.IsValid)
            {
                bool isSaved = _semesterRepository.Add(semester);
                if (isSaved)
                {
                    ViewBag.Message = "Saved Successfully..";
                }
            }
            return View();
        }
        public IActionResult Search()
        {

            var semesters = _semesterRepository.GetAll();
            return View(semesters);
        }
    }
}