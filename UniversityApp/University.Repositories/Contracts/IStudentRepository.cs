using System;
using System.Collections.Generic;
using System.Text;
using University.Models.EntityModels;

namespace University.Repositories.Contracts
{
    public interface IStudentRepository:IRepository<Student>
    {
        bool IsStudentRegNoExist(string regNo);
    }
}
