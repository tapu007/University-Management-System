using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.Models.EntityModels;
using University.Repositories.Contracts;

namespace University.Repositories.Repository
{
    public class StudentRepository:Repository<Student>,IStudentRepository
    {

        public override ICollection<Student> GetAll()
        {
            return db.Students.Include(c => c.Department).ToList();

        }

       public bool IsStudentRegNoExist(string regNo)
        {
            if (db.Students.Any(e => e.RegNo == regNo))
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
