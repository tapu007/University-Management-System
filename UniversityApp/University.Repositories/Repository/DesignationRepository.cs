using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.Models.EntityModels;
using University.Repositories.Contracts;

namespace University.Repositories.Repository
{
    public class DesignationRepository:Repository<Designation>,IDesignationRepository
    {

        public override bool Add(Designation designation)
        {
            if (IsDesignationExist(designation.DesignationName))
            {
                throw new Exception("Designation Already Exist");
            }

            return base.Add(designation);
        }


        public bool IsDesignationExist(string designation)
        {
            if (db.Designations.Any(e=>e.DesignationName == designation))
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
