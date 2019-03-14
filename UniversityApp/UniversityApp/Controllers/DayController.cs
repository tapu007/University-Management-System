using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using University.BLL.Contracts;
using University.Models.EntityModels;

namespace UniversityApp.Controllers
{
    public class DayController : Controller
    {
        private IDayManager _dayManager;
        public DayController(IDayManager dayManager)
        {
            _dayManager = dayManager;

        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Day day)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (_dayManager.Add(day))
                    {
                        ViewBag.Message = "Day Saved Successfully";
                    }
                    else
                    {
                        ViewBag.Message = "Day Save Failled";
                    }

                }
                catch (Exception e)
                {

                    ViewBag.DayExistMessage = e.Message;
                }
            }
            return View();
        }
    }
}