using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace University.Models.EntityModels
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string RegNo { get; set; }       
        public string Email { get; set; }      
        public string ContactNo { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }            
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        
    }
}
