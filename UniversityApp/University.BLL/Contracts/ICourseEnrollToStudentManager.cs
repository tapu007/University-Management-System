using System;
using System.Collections.Generic;
using System.Text;
using University.Models.EntityModels;

namespace University.BLL.Contracts
{
    public interface ICourseEnrollToStudentManager : IManager<CourseEnrollToStudent>
    {
        List<CourseEnrollToStudent> GetAllCourseById(int studentId);
        //bool IsCourseIdExist(int courseId);

        bool IsCorseCodeExist(CourseEnrollToStudent enrollToStudent);
    }
}
