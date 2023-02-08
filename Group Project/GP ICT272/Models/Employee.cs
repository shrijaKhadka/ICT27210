using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GP_ICT272.Models
{
    public class Employee
    {
        [Required]
        public int EmployeeID { get; set; }

        [StringLength(100, MinimumLength =5)]
        public string Name { get; set; }
        [Required]
        public string Position { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}