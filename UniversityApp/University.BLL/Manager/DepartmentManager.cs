using System;
using System.Collections.Generic;
using System.Text;
using University.BLL.Contracts;
using University.Models.EntityModels;
using University.Repositories.Contracts;

namespace University.BLL.Manager
{
    public class DepartmentManager : Manager<Department>, IDepartmentManager
    {
        private IDepartmentRepository _departmentRepository;

        public DepartmentManager(IDepartmentRepository repository) : base(repository)
        {
            _departmentRepository = repository;
        }

        public override bool Add(Department department)
        {
            if (IsDepartmentCodeExist(department.DepartmentCode))
            {
                throw new Exception("Department Code Allready Exist");
            }
            if (IsDepartmentNameExist(department.DepartmentName))
            {
                throw new Exception("Department Name Allready Exist");
            }
            return base.Add(department);
        }
        public bool IsDepartmentNameExist(string departmentName)
        {
            return _departmentRepository.IsDepartmentNameExist(departmentName);

        }
        public bool IsDepartmentCodeExist(string departmentCode)
        {

            return _departmentRepository.IsDepartmentCodeExist(departmentCode);
        }

    }
}
