using System;
using System.Collections.Generic;
using System.Text;
using University.DatabaseContexts.UniversityDatabaseContext;
using University.Repositories.Contracts;

namespace University.Repositories.Repository
{
    public class UnAllocateAllClassRoomRepository : IUnAllocateAllClassRoomRepository
    {
        public DatabaseContext db = new DatabaseContext();

        public bool Update()
        {

            //db.CourseAssignToTeachers
            ////.Where(e=>e.TeacherId ==courseAssignToTeacher.TeacherId)
            //.ToList()
            foreach (var classRoom in db.AllocateClassRooms)
            {
                classRoom.IsActive = false;
            }
            return db.SaveChanges() > 0;

        }
    }
}
