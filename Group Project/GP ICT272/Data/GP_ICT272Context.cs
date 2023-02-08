using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GP_ICT272.Data
{
    public class GP_ICT272Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public GP_ICT272Context() : base("name=GP_ICT272Context")
        {
        }

        public System.Data.Entity.DbSet<GP_ICT272.Models.Event> Events { get; set; }

        public System.Data.Entity.DbSet<GP_ICT272.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<GP_ICT272.Models.Booking> Bookings { get; set; }

        public System.Data.Entity.DbSet<GP_ICT272.Models.User> Users { get; set; }
    }
}
