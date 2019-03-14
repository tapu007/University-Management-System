using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using University.BLL.Contracts;

namespace UniversityApp.Controllers
{
    public class DepartmentWiseCourseController : Controller
    {
        private IDepartmentManager _departmentManager;
        private ICourseManager _courseManager;

        public DepartmentWiseCourseController(IDepartmentManager departmentManager,ICourseManager courseManager)
        {
            _departmentManager = departmentManager;
            _courseManager = courseManager;
        }
        public IActionResult DepartmentWiseCourse()
        {
            ViewBag.DepartmentId = new SelectList(_departmentManager.GetAll(), "DepartmentId", "DepartmentName");
            return View();
        }

        public IActionResult GetCourse(int departmentId)
        {
            var courses = _courseManager.GetAllCourseById(departmentId);
            if (courses != null)
            {
                return PartialView("_DepartmentWiseCourse", courses);
            }
            else
            {
                return null;
            }

            
        }
    }
}