using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace University.Models.EntityModels
{
    public class Semester
    {
        public int SemesterId { get; set; }
        [Required]
        [Display(Name ="Semester Name")]
        public string SemesterName { get; set; }      
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Student> Students { get; set; }




    }
}
