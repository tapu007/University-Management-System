
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.Models.EntityModels;
using University.Repositories.Contracts;

namespace University.Repositories.Repository
{
    public class DayRepository:Repository<Day>,IDayRepository
    {
        public bool IsDayExist(string day)
        {
            if (db.Days.Any(c=>c.DayName == day))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
