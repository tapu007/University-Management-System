using System;
using System.Collections.Generic;
using System.Text;
using University.Models.EntityModels;

namespace University.Repositories.Contracts
{
    public interface ICourseEnrollToStudentRepository:IRepository<CourseEnrollToStudent>
    {
        List<CourseEnrollToStudent> GetCourseById(int studentId);
        bool IsCorseCodeExist(CourseEnrollToStudent enrollToStudent);
        //bool IsCourseIdExist(int courseId);

    }
}
