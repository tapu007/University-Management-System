using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.BLL.Contracts;
using University.Models.EntityModels;
using University.Repositories.Contracts;

namespace University.BLL.Manager
{
    public class CourseEnrollToStudentManager : Manager<CourseEnrollToStudent>, ICourseEnrollToStudentManager
    {
        private ICourseEnrollToStudentRepository _courseEnrollToStudentRepository;
        public CourseEnrollToStudentManager(ICourseEnrollToStudentRepository repository) : base(repository)
        {
            _courseEnrollToStudentRepository = repository;
        }

        public List<CourseEnrollToStudent> GetAllCourseById(int studentId)
        {
            return _repository.GetAll().Where(c => c.StudentId == studentId).ToList();
        }

        public override bool Add(CourseEnrollToStudent course)
        {
            if (_courseEnrollToStudentRepository.IsCorseCodeExist(course))
            {
                throw new Exception("This Course Is Allready Assigned To This Student");
            }
            
            return base.Add(course);
        }
        public bool IsCorseCodeExist(CourseEnrollToStudent enrollToStudent)
        {

            return _courseEnrollToStudentRepository.IsCorseCodeExist(enrollToStudent);

        }

      
    }
}
