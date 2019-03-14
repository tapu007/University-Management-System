using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace University.Models.EntityModels
{
    public class Department
    {
       
            public int DepartmentId { get; set; }      
            public string DepartmentCode { get; set; }         
            public string DepartmentName { get; set; }
            public IEnumerable<Course> Courses { get; set; }
            public IEnumerable<Student> Students { get; set; }
            public IEnumerable<Teacher> Teachers { get; set; }



     
    }
}
