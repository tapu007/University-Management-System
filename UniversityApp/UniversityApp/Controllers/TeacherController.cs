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
    public class TeacherController : Controller
    {
        private ITeacherRepository _teacherRepository;
        private IDepartmentManager _departmentManager;
        private IDesignationRepository _designationRepository;
        private IMapper _mapper;
        public TeacherController(ITeacherRepository teacherRepository,IDepartmentManager departmentManager,IDesignationRepository designationRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _departmentManager = departmentManager;
            _designationRepository = designationRepository;
            _mapper = mapper;
        }
        public IActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(_departmentManager.GetAll(), "DepartmentId", "DepartmentName");
            ViewBag.DesignationId = new SelectList(_designationRepository.GetAll(), "DesignationId", "DesignationName");
            return View();           
        }

        [HttpPost]
        public IActionResult Create(TeacherViewModel teacherViewModel)
        {
            var teacher = _mapper.Map<Teacher>(teacherViewModel);

            if (ModelState.IsValid)
            {
                try
                {
                    if (_teacherRepository.Add(teacher))
                    {
                        ViewBag.Message = "Teacher Saved succesfully";
                        ModelState.Clear();
                    }
                    else
                    {
                        ViewBag.Message = "Teacher Save failed";
                    }
                }
                catch (Exception e)
                {
                    ViewBag.TeacherExistMessage = e.Message;
                }
            }
            ViewBag.DepartmentId = new SelectList(_departmentManager.GetAll(), "DepartmentId", "DepartmentName");
            ViewBag.DesignationId = new SelectList(_designationRepository.GetAll(), "DesignationId", "DesignationName");
            return View();
        }
        public IActionResult Search()
        {
            //TeacherRepository teacherRepository = new TeacherRepository();
            //return View(teacherRepository.GetAll());
            var teacher = _teacherRepository.GetAll();
            return View(teacher);
        }
    }
}