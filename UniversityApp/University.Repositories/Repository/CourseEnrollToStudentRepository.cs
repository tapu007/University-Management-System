using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.Models.EntityModels;
using University.Repositories.Contracts;

namespace University.Repositories.Repository
{
    public class CourseEnrollToStudentRepository : Repository<CourseEnrollToStudent>,ICourseEnrollToStudentRepository
    {
        public List<CourseEnrollToStudent> GetCourseById(int studentId)
        {
            return db.CourseEnrollToStudents.Where(c => c.StudentId == studentId).ToList();

        }

        //public override bool Add(CourseEnrollToStudent courseEnrollToStudent)
        //{
        //    if (IsCourseIdExist(courseEnrollToStudent.CourseId))
        //    {
        //        throw new Exception("Course Allready Exist");
        //    }
        //    return base.Add(courseEnrollToStudent);
        //}

        //public bool IsCourseIdExist(int courseId)
        //{
        //    if (db.CourseEnrollToStudents.Any(e => e.CourseId == courseId))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}


        public bool IsCorseCodeExist(CourseEnrollToStudent enrollToStudent)
        {
            if (db.CourseEnrollToStudents.Any(e => e.StudentId == enrollToStudent.StudentId && e.CourseId == enrollToStudent.CourseId))
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
