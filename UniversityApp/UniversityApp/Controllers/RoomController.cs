using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using University.BLL.Contracts;
using University.Models.EntityModels;

namespace UniversityApp.Controllers
{
    public class RoomController : Controller
    {
        private IRoomManager _roomManager;
        public RoomController(IRoomManager roomManager)
        {
            _roomManager = roomManager;
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(Room room)
        {
            if (ModelState.IsValid)
            {
                bool isSaved = _roomManager.Add(room);
                if (isSaved)
                {
                    ViewBag.Message = "Saved Successfully..";
                }
            }
            return View();

        }
    }
}