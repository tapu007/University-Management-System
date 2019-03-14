using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace University.Models.EntityModels
{
    public class Teacher
    {
        public int TeacherId { get; set; }      
        public string TeacherName { get; set; }
        public string Address { get; set; }      
        public string PhoneNo { get; set; }       
        public string Email { get; set; }           
        public float TakenCredit { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int DesignationId { get; set; }
        public Designation Designation { get; set; }

       
        

    }
}
