using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace atnd.Models
{
    public class Attendee
    {
        public int AttendeeID { get; set; }

        [Required, StringLength(20)]
        public string Name { get; set; }

        [Required, StringLength(20), Display(Name="e-mail")]
        public string Email { get; set; }

        [StringLength(30)]
        public string Comment { get; set; }
    }
}