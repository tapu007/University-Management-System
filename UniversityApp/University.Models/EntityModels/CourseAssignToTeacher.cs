using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace University.Models.EntityModels
{
    public class CourseAssignToTeacher
    {
        public int CourseAssignToTeacherId { get; set; }      
        public int DepartmentId { get; set; }     
        public int CourseId { get; set; }
        public int TeacherId { get; set; }
      
    }
}
