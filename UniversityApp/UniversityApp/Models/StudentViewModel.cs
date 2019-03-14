using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityApp.Models
{
    public class StudentViewModel
    {
        public int StudentViewModelId { get; set; }
        [Required(ErrorMessage = "Please Enter Student name")]
        [Display(Name ="Student Name")]
        public string StudentName { get; set; }
        [Display(Name = "Registration No.")]
        [Required(ErrorMessage ="Please Enter Student Registration Number")]
        public string RegNo { get; set; }
        [Required(ErrorMessage = "Please Enter Email address")]
        [EmailAddress]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter correct email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Contact No")]
        [DisplayName("Contact No.")]
        public string ContactNo { get; set; }
        [Required(ErrorMessage = "Please Enter Date")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Please Enter Full Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Select Department")]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }     
    }
}
