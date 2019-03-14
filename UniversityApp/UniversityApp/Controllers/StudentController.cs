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
    public class StudentController : Controller
    {
        private IStudentManager _studentManager;
        private IDepartmentManager _departmentManager;
        private IMapper _mapper;

        public StudentController(IStudentManager studentManager,IDepartmentManager departmentManager, IMapper mapper)
        {
            _departmentManager = departmentManager;
            _studentManager = studentManager;
            _mapper = mapper;
        }
        public IActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(_departmentManager.GetAll(), "DepartmentId", "DepartmentName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentViewModel studentViewModel)
        {
            var student = _mapper.Map<Student>(studentViewModel);
            if (ModelState.IsValid)
            {
                try
                {
                    if (_studentManager.Add(student))
                    {
                        ViewBag.Message = "Saved Successfully..";
                        ModelState.Clear();
                    }
                    else
                    {
                        ViewBag.Message = "Save Failed";
                    }
                }
                catch (Exception e)
                {

                    ViewBag.StudentRegNoMessage = e.Message;
                }
                
                

            }
            ViewBag.DepartmentId = new SelectList(_departmentManager.GetAll(), "DepartmentId", "DepartmentName");
            return View();
        }
    }
}