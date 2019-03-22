using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using University.Repositories.Repository;

namespace UniversityApp.Controllers
{
    public class UnAssignAllCoursesController : Controller
    {
        public UnAssignAllCoursesRepository unAssignAllCoursesRepository = new UnAssignAllCoursesRepository();
        public IActionResult UnAssignAllCourses()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UnAssignAllCourses(string any)
        {
            if (unAssignAllCoursesRepository.Update())
            {
                ViewBag.Message = "Unallocate All Teachser successfully";
            }
            else
            {
                ViewBag.Message = "Unallocate All Teacher failed";
            }
            return View();
        }
    }
}