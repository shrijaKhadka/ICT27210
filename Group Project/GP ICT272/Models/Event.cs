using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GP_ICT272.Models
{
    public class Event
    {
        public int EventID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string EventDescription { get; set; }
        public string Duration { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}