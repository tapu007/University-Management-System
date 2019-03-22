using System;
using System.Collections.Generic;
using System.Text;
using University.BLL.Contracts;
using University.Models.EntityModels;
using University.Repositories.Contracts;

namespace University.BLL.Manager
{
    public class StudentResultManager : Manager<StudentResult>, IStudentResultManager
    {
        private IStudentResultRepository _studentResultRepository;
        public StudentResultManager(IStudentResultRepository repository) : base(repository)
        {
            _studentResultRepository = repository;
        }

        public override bool Add(StudentResult grade)
        {
            if (IsResultExist(grade))
            {
                throw new Exception(" This Course Is Allready Graded");
            }
            return base.Add(grade);
        }

        public bool IsResultExist(StudentResult studentResult)
        {
            return _studentResultRepository.IsResultExist(studentResult);
            
        }
    }
}
