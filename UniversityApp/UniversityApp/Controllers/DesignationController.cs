using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using University.Models.EntityModels;
using University.Repositories.Contracts;
using UniversityApp.Models;

namespace UniversityApp.Controllers
{

    public class DesignationController : Controller
    {
        private IDesignationRepository _designationRepository;
        private IMapper _mapper;
        public DesignationController(IDesignationRepository designationRepository,IMapper mapper)
        {
            _designationRepository = designationRepository;
            _mapper = mapper;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DesignationViewModel designationViewModel)
        {
            var designation = _mapper.Map<Designation>(designationViewModel);
            if (ModelState.IsValid)
            {
                try
                {
                    if (_designationRepository.Add(designation))
                    {
                        ViewBag.Message = "Designation Saved Successfully";
                        ModelState.Clear();
                    }
                    else
                    {
                        ViewBag.Message = "Designation Save Failled";
                    }
                }
                catch (Exception e)
                {

                    ViewBag.DesignationMessage = e.Message;
                }

            }
            return View();
        }
        public IActionResult Search()
        {

            var designation = _designationRepository.GetAll();
            return View(designation);
        }

    }
}