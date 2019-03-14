using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using University.BLL.Contracts;
using University.Models.EntityModels;
using University.Repositories.Contracts;

namespace UniversityApp.Controllers
{
    public class AllocateClassRoomController : Controller
    {
        private IAllocateClassRoomManager _allocateClassRoomManager;
        private IDepartmentManager _departmentManager;
        private ICourseManager _courseManager;
        private IRoomManager _roomManager;
        private IDayManager _dayManager;

        public AllocateClassRoomController(IAllocateClassRoomManager allocateClassRoomManager,IDepartmentManager departmentManager,ICourseManager courseManager,IRoomManager roomManager,IDayManager dayManager)
        {
            _allocateClassRoomManager = allocateClassRoomManager;
            _departmentManager = departmentManager;
            _courseManager = courseManager;
            _roomManager = roomManager;
            _dayManager = dayManager;
        }
        public IActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(_departmentManager.GetAll(), "DepartmentId", "DepartmentName");
            ViewBag.RoomId = new SelectList(_roomManager.GetAll(), "RoomId", "RoomNo");
            ViewBag.DayId = new SelectList(_dayManager.GetAll(), "DayId", "DayName");

            return View();
        }
        public IActionResult GetCourseBy(int departmentId)
        {
            var courses = _courseManager.GetAllCourseById(departmentId);
            return Json(courses);

        }


    }
}