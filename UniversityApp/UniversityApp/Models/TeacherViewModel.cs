using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using University.Models.EntityModels;

namespace UniversityApp.Models
{
    public class TeacherViewModel
    {
        public int TeacherViewModelId { get; set; }
        [Required(ErrorMessage = "Please enter Teacher Name")]
        [Display(Name = "Teacher Name")]
        public string TeacherName { get; set; }
        [Required(ErrorMessage = "Please enter Address ")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter Contact No")]
        [Display(Name = "Phone No.")]
        public string PhoneNo { get; set; }
        [Required(ErrorMessage = "Please enter Email Address")]       
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter correct email address")]
        public string Email { get; set; }
        [Display(Name = "Credit To Be Taken")]
        [Required(ErrorMessage = "Please enter Credit")]
        public float TakenCredit { get; set; }
        [Required(ErrorMessage = "Please select Department")]
        [Display(Name ="Department")]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Please select Designation")]
        [Display(Name ="Designation")]
        public int DesignationId { get; set; }



        
        
       
        
       
        
       
       
       
       
        
       
        
        
       
        



    }
}
