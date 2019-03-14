using System;
using System.Collections.Generic;
using System.Text;
using University.BLL.Contracts;
using University.Models.EntityModels;
using University.Repositories.Contracts;

namespace University.BLL.Manager
{
    public class StudentResultManager : Manager<StudentResult>, IStudentResultManager
    {
        public StudentResultManager(IStudentResultRepository repository) : base(repository)
        {
        }
    }
}
