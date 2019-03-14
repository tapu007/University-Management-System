using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityApp.Models
{
    public class DepartmentWiseCourse
    {
        public int DepartmentId { get; set; }
        public int CourseId { get; set; }      
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string SemesterName { get; set; }
        public string AssignedTo { get; set; }



    }
}
