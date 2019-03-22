using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.DatabaseContexts.UniversityDatabaseContext;
using University.Models.EntityModels;
using University.Repositories.Contracts;

namespace University.Repositories.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
       
        public List<Course> GetCourseById(int departmentId)
        {
            return db.Courses.Where(c => c.DepartmentId == departmentId).ToList();

        }
        public override ICollection<Course> GetAll()
        {
            return db.Courses.Include(c => c.Department).Include(m=>m.Semester).ToList();

        }


        public bool IsCourseCodeExist(string courseCode)
        {
            if (db.Courses.Any(c=>c.CourseCode == courseCode))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsCourseNameExist(string courseName)
        {
            if (db.Courses.Any(c=>c.CourseName == courseName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
