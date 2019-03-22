using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.Models.EntityModels;
using University.Repositories.Contracts;

namespace University.Repositories.Repository
{
    public class StudentResultRepository : Repository<StudentResult>,IStudentResultRepository
    {
        public bool IsResultExist(StudentResult studentResult)
        {
            if (db.StudentResults.Any(e =>e.StudentId ==studentResult.StudentId && e.CourseId == studentResult.CourseId))
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
