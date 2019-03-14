using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace University.Models.EntityModels
{
    public class Day
    {
        public int DayId { get; set; }
        [Required]
        [Display(Name ="Day")]
        public string DayName { get; set; }

    }
}
