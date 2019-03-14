using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using University.BLL.Contracts;
using University.DatabaseContexts.UniversityDatabaseContext;
using University.Models.EntityModels;
using University.Repositories.Contracts;
using University.Repositories.Repository;
using UniversityApp.Models;

namespace UniversityApp.Controllers
{
    public class CourseController : Controller
    {
        private IDepartmentManager _departmentManager;
        private ISemesterRepository _semesterRepository;
        private ICourseManager _courseManager;
        private IMapper _mapper;
        public CourseController(ICourseManager courseManager,IDepartmentManager departmentManager,ISemesterRepository semesterRepository, IMapper mapper)
        {
            _courseManager = courseManager;
            _departmentManager = departmentManager;
            _semesterRepository = semesterRepository;
            _mapper = mapper;
            
        }

        [Authorize]
        public IActionResult Create()
        {
            
            ViewBag.DepartmentId = new SelectList(_departmentManager.GetAll(), "DepartmentId", "DepartmentName");
            ViewBag.SemesterId = new SelectList(_semesterRepository.GetAll(), "SemesterId", "SemesterName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(CourseViewModle courseViewModle)
        {
            
            var course = _mapper.Map<Course>(courseViewModle);

            if (ModelState.IsValid)
            {
                try
                {
                    if (_courseManager.Add(course))
                    {
                        ViewBag.Message = "Course Save succesfully";
                        ModelState.Clear();
                    }
                    else
                    {
                        ViewBag.Message = "Course Save failed";
                    }
                }
                catch (Exception e)
                {
                    ViewBag.CourseExistMessage = e.Message;
                }
            }

            ViewBag.DepartmentId = new SelectList(_departmentManager.GetAll(), "DepartmentId", "DepartmentName");
            ViewBag.SemesterId = new SelectList(_semesterRepository.GetAll(), "SemesterId", "SemesterName");
            return View();
        }
        public IActionResult Search()
        {


            //CourseRepository courseRepository = new CourseRepository();
            //return View(courseRepository.GetAll());           
            return View(_courseManager.GetAll());
        }
    }
}