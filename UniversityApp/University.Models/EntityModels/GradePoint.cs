using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace University.Models.EntityModels
{
    public class GradePoint
    {
        public int GradePointId { set; get; }
        [Required]
        [Display(Name ="Grade Name")]
        public string GradeName { set; get; }
    }
}
