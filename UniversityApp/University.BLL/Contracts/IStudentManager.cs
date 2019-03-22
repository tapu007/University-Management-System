using System;
using System.Collections.Generic;
using System.Text;
using University.Models.EntityModels;

namespace University.BLL.Contracts
{
    public interface IStudentManager:IManager<Student>
    {
        bool IsStudentRegNoExist(string regNo);

    }
}
