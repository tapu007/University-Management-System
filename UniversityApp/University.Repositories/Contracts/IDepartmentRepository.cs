using System;
using System.Collections.Generic;
using System.Text;
using University.Models;
using University.Models.EntityModels;

namespace University.Repositories.Contracts
{
    public interface IDepartmentRepository:IRepository<Department>
    {
        //bool IsDepartmentNameExist(string departmentName);
        bool IsDepartmentNameExist(string departmentName);
        bool IsDepartmentCodeExist(string departmentCode);
    }
}
