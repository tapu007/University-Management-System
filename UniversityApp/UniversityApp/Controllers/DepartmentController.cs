using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using University.BLL.Contracts;
using University.Models.EntityModels;
using University.Repositories.Contracts;
using UniversityApp.Models;

namespace UniversityApp.Controllers
{
    public class DepartmentController : Controller
    {
        private IDepartmentManager _departmentManager;
        private IDepartmentRepository _departmentRepository;
        private IMapper _mapper;
        public DepartmentController(IDepartmentManager departmentManager,IDepartmentRepository departmentRepository,IMapper mapper)
        {
            _departmentManager = departmentManager;
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(DepartmentViewModel departmentViewModel)
        {
            if (ModelState.IsValid)
            {
                var department = _mapper.Map<Department>(departmentViewModel);  

                try
                {
                    if (_departmentManager.Add(department))
                    {
                        ViewBag.Message = "Department Save succesfully";
                        ModelState.Clear();
                    }
                    else
                    {
                        ViewBag.Message = "Department Save failed";
                    }
                }
                catch (Exception e)
                {
                    ViewBag.DepartmentExistMessage = e.Message;
                }
             
                return View();





                //var department = _mapper.Map<Department>(departmentViewModel);            
                //if (_departmentRepository.IsDepartmentNameExist(department.DepartmentName))
                //{

                //    if (_departmentRepository.IsDepartmentCodeExist(department.DepartmentCode))
                //    {
                //        bool isSaved = _departmentRepository.Add(department);
                //        if (isSaved)
                //        {
                //            ViewBag.Message = "Department Saved Successfully..";
                //        }
                //    }

                //}
                //else
                //{
                //    ViewBag.DepartmentNameExistMessage = "Department Name Exist";
                //    ViewBag.DepartmentCodeExistMessage = "Department Code Exist";
                //}
            }
            return View();
        }
        public IActionResult Search()
        {

            var department = _departmentManager.GetAll();
            return View(department);
        }


    }
}