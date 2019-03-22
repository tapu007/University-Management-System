using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using University.BLL.Contracts;
using University.Models.EntityModels;
using UniversityApp.Models;

namespace UniversityApp.Controllers
{
    public class StudentResultController : Controller
    {
        private IStudentResultManager _studentResultManager;
        private IStudentManager _studentManager;
        private IGradePointManager _gradePointManager;
        private ICourseManager _courseManager;
        private ICourseEnrollToStudentManager _courseEnrollToStudentManager;
        private IMapper _mapper;

        public StudentResultController(IStudentResultManager studentResultManager,IStudentManager studentManager,IGradePointManager gradePointManager,ICourseManager courseManager,ICourseEnrollToStudentManager courseEnrollToStudentManager, IMapper mapper)
        {
            _studentResultManager = studentResultManager;
            _studentManager = studentManager;
            _gradePointManager = gradePointManager;
            _courseManager = courseManager;
            _courseEnrollToStudentManager = courseEnrollToStudentManager;
            _mapper = mapper;
        }
        public IActionResult Create()
        {
            ViewBag.StudentId = new SelectList(_studentManager.GetAll(), "StudentId", "RegNo");
            ViewBag.GradePointId = new SelectList(_gradePointManager.GetAll(), "GradePointId", "GradeName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentResultViewModel studentResultViewModel)
        {

            var studentResult = _mapper.Map<StudentResult>(studentResultViewModel);
            if (ModelState.IsValid)
            {
                try
                {
                    bool isSaved = _studentResultManager.Add(studentResult);
                    if (isSaved)
                    {
                        ViewBag.Message = "Result Saved To Student Successfully";
                    }
                    else
                    {
                        ViewBag.Message = "Result Save Failled";
                    }
                }
                catch (Exception e)
                {

                    ViewBag.GradeExistMessage = e.Message;
                }
               
            }
            ViewBag.StudentId = new SelectList(_studentManager.GetAll(), "StudentId", "RegNo");
            ViewBag.GradePointId = new SelectList(_gradePointManager.GetAll(), "GradePointId", "GradeName");
            return View();
        }

        public IActionResult GetStudentInfoBy(int studentId)
        {
            var studentInfo = _studentManager.GetBy(studentId);
            return Json(studentInfo);
        }
        public IActionResult GetAllCourseBy(int studentId)
        {
            var courses = _courseEnrollToStudentManager.GetAllCourseById(studentId);
            return Json(courses);




        }

    }
}