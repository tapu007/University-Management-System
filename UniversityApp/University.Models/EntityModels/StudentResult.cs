using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace University.Models.EntityModels
{
    public class StudentResult
    {
        public int StudentResultId { get; set; }       
        public int StudentId { get; set; }                   
        public int CourseId { get; set; }
        public int GradePointId { get; set; }


    }
}
