using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using University.BLL.Contracts;
using University.BLL.Manager;
using University.Models.EntityModels;
using University.Repositories.Contracts;
using UniversityApp.Models;

namespace UniversityApp.Controllers
{
    public class CourseEnrollToStudentController : Controller
    {
        private ICourseEnrollToStudentManager _courseEnrollToStudentManager;       
        private IStudentManager _studentManager;
        private ICourseManager _courseManager;
        private IDepartmentManager _departmentManager;
        //private IMapper _mapper;




        public CourseEnrollToStudentController(ICourseEnrollToStudentManager courseEnrollToStudentManager, IStudentManager studentManager,ICourseManager courseManager,IDepartmentManager departmentManager/* IMapper mapper*/)
        {
            _courseEnrollToStudentManager = courseEnrollToStudentManager;
            _studentManager = studentManager;
            _courseManager = courseManager;
            _departmentManager = departmentManager;
            //_mapper = mapper;
        }
        public IActionResult Create()
        {
            ViewBag.StudentId = new SelectList(_studentManager.GetAll(), "StudentId", "RegNo");
            return View();
        }
        [HttpPost]
        public IActionResult Create(CourseEnrollToStudent courseEnrollToStudent)
        {
            //var courseEnrollToStudnet = _mapper.Map<CourseEnrollToStudent>(courseEnrollToStudentViewModel);

            if (ModelState.IsValid)
            {


                //bool isSaved = _courseEnrollToStudentManager.Add(courseEnrollToStudent);
                //if (isSaved)
                //{
                //    ViewBag.Message = "Saved";

                //}
                //else
                //{
                //    ViewBag.Message = "failed";
                //}
                try
                {
                    if (_courseEnrollToStudentManager.Add(courseEnrollToStudent))
                    {
                        ViewBag.Message = "Course Enrolled succesfully";
                        ModelState.Clear();
                    }
                    else
                    {
                        ViewBag.Message = "Course Enroll failed";
                    }
                }
                catch (Exception e)
                {
                    ViewBag.CourseExistMessage = e.Message;
                }




            }
            ViewBag.StudentId = new SelectList(_studentManager.GetAll(), "StudentId", "RegNo");
            return View();
        }
        public IActionResult GetStudentInfoBy(int studentId)
        {
            var course = _studentManager.GetBy(studentId);
            return Json(course);
        }
        public IActionResult GetAllCourseBy(int departmentId)
        {
            var courses = _courseManager.GetAllCourseById(departmentId);
            return Json(courses);
        }

    }
}