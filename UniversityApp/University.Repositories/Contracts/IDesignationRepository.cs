using System;
using System.Collections.Generic;
using System.Text;
using University.Models.EntityModels;

namespace University.Repositories.Contracts
{
    public interface IDesignationRepository:IRepository<Designation>
    {
        bool IsDesignationExist(string designation);
    }
}
