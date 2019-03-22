using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace University.Models.EntityModels
{
    public class CourseEnrollToStudent
    {
        public int CourseEnrollToStudentId { get; set; }
        [Required(ErrorMessage = "Please select Student Reg:No")]
        [DisplayName("Student Reg: No")]
        public int StudentId { get; set; }       
        [Required(ErrorMessage = "Please select Department")]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }     
        [Required(ErrorMessage = "Please select Course Name")]
        [DisplayName("Course Name")]
        public int CourseId { get; set; }      
        [Required(ErrorMessage = "Please select Date")]
        [DisplayName("Date")]
        public DateTime EnrollDate { get; set; }


        
        
    }
}
