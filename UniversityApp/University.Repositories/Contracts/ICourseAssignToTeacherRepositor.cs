using System;
using System.Collections.Generic;
using System.Text;
using University.Models.EntityModels;

namespace University.Repositories.Contracts
{
    public interface ICourseAssignToTeacherRepositor:IRepository<CourseAssignToTeacher>
    {
        bool IsCourseExist(int courseId);
        bool IsCourseExistToThisTeacher(CourseAssignToTeacher courseAssignToTeacher);


    }
}
