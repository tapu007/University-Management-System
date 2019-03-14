using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityApp.Models
{
    public class CourseViewModle
    {
        
        public int CourseViewModleId { get; set; }
        [Required]
        [Display(Name = "Course Code")]
        public string CourseCode { get; set; }
        [Required]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }
        [Display(Name = "Department Name")]
        public int DepartmentId { get; set; }       
        [Display(Name = "Semester Name")]
        public string DepartmentName { get; set; }
        public int SemesterId { get; set; }        
        [Required]
        public float Credit { get; set; }    
        





    }
}
