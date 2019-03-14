using System;
using System.Collections.Generic;
using System.Text;
using University.Models.EntityModels;

namespace University.BLL.Contracts
{
    public interface ICourseManager : IManager<Course>
    {
        List<Course> GetAllCourseById(int departmentId);
        bool IsCourseNameExist(string courseName);
        bool IsCourseCodeExist(string courseCode);


        //Course GetCourseInfoBy(int courseId);


    }
}
