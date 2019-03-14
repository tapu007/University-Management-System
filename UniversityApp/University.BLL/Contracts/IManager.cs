using System;
using System.Collections.Generic;
using System.Text;

namespace University.BLL.Contracts
{
    public interface IManager<T>where T:class
    {
        bool Add(T entity);
        ICollection<T> GetAll();
        T GetBy(int Id);
    }
}
