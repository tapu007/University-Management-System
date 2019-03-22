using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.DatabaseContexts.UniversityDatabaseContext;
using University.Models.EntityModels;

namespace University.Repositories.Repository
{
    
    public class UnAssignAllCoursesRepository
    {
        public DatabaseContext db = new DatabaseContext();

        public bool Update()
        {
            
            //db.CourseAssignToTeachers
            ////.Where(e=>e.TeacherId ==courseAssignToTeacher.TeacherId)
            //.ToList()
            foreach (var c in db.CourseAssignToTeachers)
            {
                c.IsActive = false ;
            }
            return db.SaveChanges()>0;

        }
    }
}
