using System;
using System.Collections.Generic;
using System.Text;
using University.Models.EntityModels;

namespace University.Repositories.Contracts
{
    public interface IDayRepository:IRepository<Day>
    {
        bool IsDayExist(string day);
    }
}
