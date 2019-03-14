using System;
using System.Collections.Generic;
using System.Text;
using University.BLL.Contracts;
using University.Models.EntityModels;
using University.Repositories.Contracts;

namespace University.BLL.Manager
{
    public class DayManager : Manager<Day>, IDayManager
    {
        private IDayRepository _dayRepository;
        public DayManager(IDayRepository repository) : base(repository)
        {
            _dayRepository = repository;
            
        }

        public override bool Add(Day day)
        {
            if (IsDayExist(day.DayName))
            {
                throw new Exception("Day Allready Exist");
            }
            return base.Add(day);
        }

        public bool IsDayExist(string day)
        {
            return _dayRepository.IsDayExist(day);

        }
    }
}
