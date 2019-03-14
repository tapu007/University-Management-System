using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityApp.Models
{
    public class DepartmentViewModel
    {
        public int DepartmentViewModelId { get; set; }
        [Required]
        [Display(Name = "Department Code")]
        [StringLength(maximumLength:4)]
        public string DepartmentCode { get; set; }
        [Required]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }



    }
}
