using System;
using System.Collections.Generic;
using System.Text;
using University.Models.EntityModels;

namespace University.Repositories.Contracts
{
    public interface IStudentResultRepository : IRepository<StudentResult>
    {
        bool IsResultExist(StudentResult studentResult);
    }
}
