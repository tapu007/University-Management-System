using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.DatabaseContexts.UniversityDatabaseContext;
using University.Repositories.Contracts;

namespace University.Repositories.Repository
{
    public class Repository<T>:IRepository<T>where T:class
    {
        protected DatabaseContext db = new DatabaseContext();

        public DbSet<T> Table
        {
            get { return db.Set<T>(); }
        }
        public virtual bool Add(T entity)
        {
            Table.Add(entity);
            return db.SaveChanges() > 0;

        }
        public virtual bool update(T entity)
        {
            Table.Update(entity);
            return db.SaveChanges() > 0;

        }
        public virtual ICollection<T> GetAll()
        {

            return Table.ToList();
        }

        public virtual T GetBy(int Id)
        {

            return Table.Find(Id);
        }

    }
}
