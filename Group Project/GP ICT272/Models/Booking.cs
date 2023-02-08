using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GP_ICT272.Models
{
    public class Booking
    {
        [Required]
        public int BookingID { get; set; }
        public int EventID { get; set; }
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Event Event { get; set; }
     
    }
}