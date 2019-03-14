using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.Models.EntityModels;
using University.Repositories.Contracts;

namespace University.Repositories.Repository
{
    public class CourseAssignToTeacherRepository:Repository<CourseAssignToTeacher>,ICourseAssignToTeacherRepositor
    {

        public override bool Add(CourseAssignToTeacher courseAssignToTeacher)
        {
            if (IsCourseExist(courseAssignToTeacher.CourseId))
            {
                throw new Exception("Course Allready Assigned To A Teacher");
            }
            if (IsCourseExistToThisTeacher(courseAssignToTeacher))
            {
                throw new Exception("Course Allready Assigned To This Teacher");
            }
            return base.Add(courseAssignToTeacher);
        }
        public bool IsCourseExist(int courseId)
        {
            if (db.CourseAssignToTeachers.Any(e=>e.CourseId == courseId ))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsCourseExistToThisTeacher(CourseAssignToTeacher courseAssignToTeacher)
        {
            if (db.CourseAssignToTeachers.Any(e=>e.TeacherId == courseAssignToTeacher.TeacherId && e.CourseId == courseAssignToTeacher.CourseId))
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
