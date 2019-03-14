using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityApp.Models
{
    public class DesignationViewModel
    {
        public int DesignationId { get; set; }
        [Required(ErrorMessage ="Enter Designation")]
        [Display(Name = "Designation Name")]
        public string DesignationName { get; set; }
    }
}
