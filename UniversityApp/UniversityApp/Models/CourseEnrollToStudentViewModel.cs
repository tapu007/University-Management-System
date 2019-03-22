using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using University.Models.EntityModels;

namespace UniversityApp.Models
{
    public class CourseEnrollToStudentViewModel
    {
        public int EnrollCourseId { get; set; }
        [Required(ErrorMessage = "Please select Student Reg:No")]
        [DisplayName("Student Reg: No")]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Please select Department")]
        [DisplayName("Department Name")]
        public string DepartmentName { get; set; }
        [Required(ErrorMessage = "Please select Department")]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Please select Course Name")]
        [DisplayName("Course Name")]
        public string CourseName { get; set; }
        [Required(ErrorMessage = "Please select Course Name")]
        [DisplayName("Course Name")]
        public int CourseId { get; set; }
        
        [Required(ErrorMessage = "Please select Date")]
        [DisplayName("Date")]
        public DateTime EnrollDate { get; set; }

        [Required(ErrorMessage = "Please select Name")]
        [DisplayName("Student Name")]
        public string StudentName { get; set; }
        [Required(ErrorMessage = "Please select Email")]
        [DisplayName("Email")]
        public string Email { get; set; }

    }
}
