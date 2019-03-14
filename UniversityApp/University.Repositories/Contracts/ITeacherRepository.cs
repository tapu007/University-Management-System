using System;
using System.Collections.Generic;
using System.Text;
using University.Models.EntityModels;

namespace University.Repositories.Contracts
{
    public interface ITeacherRepository : IRepository<Teacher>
    {
        List<Teacher> GetByDepartmentId(int departmentId);
        //Teacher GetTeacherInfoBy(int teacherId);
        bool IsTeacherPhoneNoIsExist(string pnoneNo);
        bool IsTeacherEamilExist(string email);
    }
}
