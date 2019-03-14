using System;
using System.Collections.Generic;
using System.Text;
using University.Models.EntityModels;

namespace University.BLL.Contracts
{
    public interface IDepartmentManager:IManager<Department>
    {
        bool IsDepartmentCodeExist(string departmentCode);
        bool IsDepartmentNameExist(string departmentName);
    }
}
