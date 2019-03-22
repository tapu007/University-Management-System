using System;
using System.Collections.Generic;
using System.Text;
using University.Models.EntityModels;

namespace University.Repositories.Contracts
{
    public interface IRepository<T>where T:class
    {
        bool Add(T entity);
        ICollection<T> GetAll();
        T GetBy(int Id);
        bool update(T entity);

    }
}
