using System;
using System.Collections.Generic;
using System.Text;
using University.BLL.Contracts;
using University.Models.EntityModels;
using University.Repositories.Contracts;
using University.Repositories.Repository;

namespace University.BLL.Manager
{
    public class StudentManager : Manager<Student>, IStudentManager
    {
        private IStudentRepository _studentRepository;
        public StudentManager(IStudentRepository repository) : base(repository)
        {
            _studentRepository = repository;
        }

        public override bool Add(Student student)
        {
            if (IsStudentRegNoExist(student.RegNo))
            {
                throw new Exception("Student RegNo Already Exist");
            }

            return base.Add(student);
        }
        public bool IsStudentRegNoExist(string regNo)
        {
            return _studentRepository.IsStudentRegNoExist(regNo);

        }


      
       
    }
}
