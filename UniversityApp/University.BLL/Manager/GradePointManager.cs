using System;
using System.Collections.Generic;
using System.Text;
using University.BLL.Contracts;
using University.Models.EntityModels;
using University.Repositories.Contracts;

namespace University.BLL.Manager
{
    public class GradePointManager : Manager<GradePoint>, IGradePointManager
    {
        public GradePointManager(IGradePointRepository repository) : base(repository)
        {
        }
    }
}
