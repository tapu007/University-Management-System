using System;
using System.Collections.Generic;
using System.Text;
using University.Models.EntityModels;

namespace University.Repositories.Contracts
{
    public interface ICourseRepository : IRepository<Course>
    {
        //List<Course> GetCourseById(int departmentId);        
        //Course GetCourseInfoBy(int courseId);
        bool IsCourseCodeExist(string courseCode);
        bool IsCourseNameExist(string courseName);

    }
}
