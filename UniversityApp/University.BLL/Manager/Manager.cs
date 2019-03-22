using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.BLL.Contracts;
using University.Repositories.Contracts;

namespace University.BLL.Manager
{
    public class Manager<T> : IManager<T> where T : class
    {
        protected IRepository<T> _repository;
        public Manager(IRepository<T> repository)
        {
            _repository = repository;
        }
        public virtual bool Add(T entity)
        {
          return  _repository.Add(entity);
        }

        //public virtual bool update()
        //{

          
        //}
        public virtual ICollection<T> GetAll()
        {
            return _repository.GetAll();
        }
        public virtual T GetBy(int Id)
        {

            return _repository.GetBy(Id);
        }
    }
}
