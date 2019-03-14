using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace University.Models.EntityModels
{
    public class Course
    {
        public int CourseId { get; set; }      
        public string CourseCode { get; set; }       
        public string CourseName { get; set; }       
        public int DepartmentId { get; set; }       
        public Department Department { get; set; }
        public int SemesterId { get; set; }
        public Semester Semester { get; set; }       
        public float Credit { get; set; }       
        public List<Student> Students { get; set; }



    }
}
