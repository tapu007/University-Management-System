using Microsoft.AspNetCore.Mvc;
using University.Repositories.Repository;

namespace UniversityApp.Controllers
{
    public class UnAllocateAllClassRoomController : Controller
    {
        public UnAllocateAllClassRoomRepository unAllocateAllClassRoomRepository = new UnAllocateAllClassRoomRepository();
        public IActionResult UnAllocateAllClassRoom()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UnAllocateAllClassRoom(string classRoom)
        {
            if (ModelState.IsValid)
            {
                if (unAllocateAllClassRoomRepository.Update())
                {
                    ViewBag.Message = "Unallocate All ClassRoom successfully";
                }
                else
                {
                    ViewBag.Message = "Unallocate All ClassRoom failed";
                }
            }
           
            return View();
            
        }
    }
}