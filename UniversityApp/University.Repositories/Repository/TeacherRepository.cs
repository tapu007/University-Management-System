using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.DatabaseContexts.UniversityDatabaseContext;
using University.Models.EntityModels;
using University.Repositories.Contracts;

namespace University.Repositories.Repository
{
    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        DatabaseContext db = new DatabaseContext();
        public List<Teacher> GetByDepartmentId(int departmentId)
        {
            return db.Teachers.Where(c => c.DepartmentId == departmentId).ToList();
        }

        public override ICollection<Teacher> GetAll()
        {
            return db.Teachers.Include(c => c.Department).Include(m => m.Designation).ToList();

        }

        public override bool Add(Teacher teacher)
        {
            if (IsTeacherEamilExist(teacher.Email))
            {
                throw new Exception("Teacher Email Already Exist");

            }
            if (IsTeacherPhoneNoIsExist(teacher.PhoneNo))
            {
                throw new Exception("Teacher Pnone Number Already Exist");
            }
            return base.Add(teacher);
        }

        public bool IsTeacherEamilExist(string email)
        {
            if (db.Teachers.Any(e=>e.Email == email))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsTeacherPhoneNoIsExist(string pnoneNo)
        {
            if (db.Teachers.Any(e=>e.PhoneNo == pnoneNo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //public Teacher GetTeacherInfoBy(int teacherId)
        //{

        //    return db.Teachers.Find(teacherId);
        //}
    }
}
