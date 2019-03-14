using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityApp.Models
{
    public class StudentResultViewModel
    {
        public int StudentResultId { get; set; }
        [Required(ErrorMessage = "Please select Student Reg:No")]
        [DisplayName("Student Reg: No")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Please select Name")]
        [DisplayName("Student Name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Please select Email")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please select Department")]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Please select Course Name")]
        [DisplayName("Course Name")]
        public int CourseId { get; set; }
               
        [Required(ErrorMessage = "Please Select a Grade Letter")]
        [DisplayName("Select a Grade Letter")]
        public int GradePointId { get; set; }


    }
}
