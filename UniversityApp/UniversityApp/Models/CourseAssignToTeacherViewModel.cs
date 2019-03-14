using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityApp.Models
{
    public class CourseAssignToTeacherViewModel
    {
        public int CourseAssignToTeacherViewModelId { get; set; }

        [Required(ErrorMessage = "Please select department name ")]
        [DisplayName("Department Name")]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Please select teacher name")]
        [DisplayName("Teacher Name")]
        public int TeacherId { get; set; }
        [Required(ErrorMessage = "Please select Course Name")]
        [DisplayName("Course Code")]
        public int CourseId { get; set; }
        [DisplayName("Credit To Be Taken")]
        public float CredittobeTaken { get; set; }
        [DisplayName("RemainingCredit")]
        public float RemainingCredit { get; } = 5;        
        [Required(ErrorMessage = "Please select teacher name")]
        [Display(Name ="Course Name")]
        public string CourseName { get; set; }
        [Required(ErrorMessage = "Please select teacher name")]
        public double Credit { get; set; }
        //public List<SelectListItem> Depatrtments { get; set; }
    }
}


