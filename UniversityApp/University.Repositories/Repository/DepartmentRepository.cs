using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.Models;
using University.Models.EntityModels;
using University.Repositories.Contracts;

namespace University.Repositories.Repository
{
    public class DepartmentRepository:Repository<Department>,IDepartmentRepository
    {

       
        public bool IsDepartmentNameExist(string departmentName)
        {
            if (db.Departments.Any(e=>e.DepartmentName == departmentName))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool IsDepartmentCodeExist(string departmentCode)
        {
            if(db.Departments.Any(e=>e.DepartmentCode == departmentCode))
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
