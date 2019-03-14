using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace University.Models.EntityModels
{
    public class Room
    {
        public int RoomId { get; set; }
        [Required]
        public string RoomNo { get; set; }

    }
}
