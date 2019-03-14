using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace University.Models.EntityModels
{
    public class AllocateClassRoom
    {
        public int AllocateClassroomId { get; set; }
        [Required(ErrorMessage = "Please select department")]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Please select Course")]
        [DisplayName("Course")]
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Please select Room")]
        [DisplayName("Room")]
        public int RoomId { get; set; }
        [Required(ErrorMessage = "Please select Day")]
        [DisplayName("Day")]
        public int DayId { get; set; }
        [Required(ErrorMessage = "Please enter from time")]
        [DisplayName("From Time")]
        public string FromTime { get; set; }
        [Required(ErrorMessage = "Please enter to time")]
        [DisplayName("To Time")]
        public string ToTime { get; set; }
        [Required(ErrorMessage = "Please Select AM or PM ")]
        public string TimeFromAMPM { get; set; }
        [Required(ErrorMessage = "Please Select AM or PM")]
        public string TimeToAMPM { get; set; }

    }
}
