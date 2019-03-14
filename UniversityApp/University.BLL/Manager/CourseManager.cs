using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.BLL.Contracts;
using University.DatabaseContexts.UniversityDatabaseContext;
using University.Models.EntityModels;
using University.Repositories.Contracts;

namespace University.BLL.Manager
{
    public class CourseManager : Manager<Course>, ICourseManager
    {
        private ICourseRepository _courseRepository;
       
        public CourseManager(ICourseRepository repository) : base(repository)
        {
            _courseRepository = repository;
        }     
        public List<Course> GetAllCourseById(int departmentId)
        {
            return _repository.GetAll().Where(c => c.DepartmentId == departmentId).ToList();
        }

        public override bool Add(Course course)
        {
            if (IsCourseCodeExist(course.CourseCode))
            {
                throw new Exception("Course Code Allready Exist");
            }
            if (IsCourseNameExist(course.CourseName))
            {
                throw new Exception("Course Name Allready Exist");
            }
            return base.Add(course);
        }

        public bool IsCourseNameExist(string courseName)
        {
            return _courseRepository.IsCourseNameExist(courseName);

        }
        public bool IsCourseCodeExist(string courseCode)
        {

            return _courseRepository.IsCourseCodeExist(courseCode);
        }
        
       
       
    }
}

