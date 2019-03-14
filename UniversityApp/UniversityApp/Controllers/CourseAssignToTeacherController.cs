using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using University.BLL.Contracts;
using University.Models.EntityModels;
using University.Repositories.Contracts;
using University.Repositories.Repository;
using UniversityApp.Models;

namespace UniversityApp.Controllers
{
    public class CourseAssignToTeacherController : Controller
    {
        private ICourseAssignToTeacherRepositor _courseAssignToTeacherRepository;
        private IDepartmentManager _departmentManager;
        private ITeacherRepository _teacherRepository;
        private ICourseManager _courseManager;
        private IMapper _mapper;

        public CourseAssignToTeacherController(ICourseAssignToTeacherRepositor courseAssignToTeacherRepositor, IDepartmentManager departmentManager, ITeacherRepository teacherRepository,ICourseManager courseManager, IMapper mapper)
        {
            _courseAssignToTeacherRepository = courseAssignToTeacherRepositor;
            _departmentManager = departmentManager;
            _teacherRepository = teacherRepository;
            _courseManager = courseManager;
            _mapper = mapper;
        }
        public IActionResult Create()
        {
            //var courseAssignToTeacher = new CourseAssignToTeacherViewModel();
            //courseAssignToTeacher.Depatrtments = _departmentRepository.GetAll().Select(c => new SelectListItem
            //{
            //    Value = c.DepartmentId.ToString(),
            //    Text = c.DepartmentName

            //}).ToList();
            ViewBag.DepartmentId = new SelectList(_departmentManager.GetAll(), "DepartmentId", "DepartmentName");
            return View(/*courseAssignToTeacher*/);
        }

        [HttpPost]
        public IActionResult Create(CourseAssignToTeacherViewModel courseAssignToTeacher)
        {

            var courseAssign = _mapper.Map<CourseAssignToTeacher>(courseAssignToTeacher);
            if (ModelState.IsValid)
            {
                //var courseAssign = new CourseAssignToTeacher()
                //{
                //    DepartmentId = courseAssignToTeacherViewModel.DepartmentId,
                //    CourseAssignToTeacherId = courseAssignToTeacherViewModel.TeacherId,
                //    CourseId = courseAssignToTeacherViewModel.CourseId


                //};
                //bool isSaved = _courseAssignToTeacherRepository.Add(courseAssign);
                //if (isSaved)
                //{
                //    ViewBag.Message = "Saved Successfully..";

                //}

                try
                {
                    if (_courseAssignToTeacherRepository.Add(courseAssign))
                    {
                        ViewBag.Message = "Course Assigned Successfully";
                        ModelState.Clear();
                    }
                    else
                    {
                        ViewBag.Message = "Course Assign Failled";
                    }
                }
                catch (Exception e)
                {

                    ViewBag.CourseExistMessage = e.Message;
                }
                






            }
          
            ViewBag.DepartmentId = new SelectList(_departmentManager.GetAll(), "DepartmentId", "DepartmentName");
            return View();
        }
        public IActionResult GetTeacherBy(int departmentId)
        {
            var teachers = _teacherRepository.GetByDepartmentId(departmentId);
            return Json(teachers);

        }
        public IActionResult GetCourseBy(int departmentId)
        {
            var courses = _courseManager.GetAllCourseById(departmentId);
            return Json(courses);



        }
        public IActionResult GetCourseInfoBy(int courseId)
        {
            var course = _courseManager.GetBy(courseId);
            return Json(course);


        }
        public IActionResult GetTeacherInfoBy(int teacherId)
        {

            var teacher = _teacherRepository.GetBy(teacherId);
            return Json(teacher);
        }


    }
}