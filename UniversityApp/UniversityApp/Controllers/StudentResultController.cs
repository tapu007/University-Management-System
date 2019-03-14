using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using University.BLL.Contracts;
using University.Models.EntityModels;

namespace UniversityApp.Controllers
{
    public class StudentResultController : Controller
    {
        private IStudentResultManager _studentResultManager;
        private IStudentManager _studentManager;
        private IGradePointManager _gradePointManager;
        private ICourseManager _courseManager;
        private ICourseEnrollToStudentManager _courseEnrollToStudentManager;
        public StudentResultController(IStudentResultManager studentResultManager,IStudentManager studentManager,IGradePointManager gradePointManager,ICourseManager courseManager,ICourseEnrollToStudentManager courseEnrollToStudentManager)
        {
            _studentResultManager = studentResultManager;
            _studentManager = studentManager;
            _gradePointManager = gradePointManager;
            _courseManager = courseManager;
            _courseEnrollToStudentManager = courseEnrollToStudentManager;
           
        }
        public IActionResult Create()
        {
            ViewBag.StudentId = new SelectList(_studentManager.GetAll(), "StudentId", "RegNo");
            ViewBag.GradePointId = new SelectList(_gradePointManager.GetAll(), "GradePointId", "GradeName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentResult studentResult)
        {

            return View();
        }

        public IActionResult GetStudentInfoBy(int studentId)
        {
            var studentInfo = _studentManager.GetBy(studentId);
            return Json(studentInfo);
        }
        public IActionResult GetAllCourseBy(int studentId)
        {
            var courses = _courseManager.GetAllCourseById(studentId);
            return Json(courses);




        }

    }
}