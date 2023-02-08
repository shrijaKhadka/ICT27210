﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GP_ICT272.Models
{
    public class User
    {
       [Required]
        public int UserID { get; set; }
       
        public string Name { get; set; }
        [Required]
        [StringLength(100, ErrorMessage ="The {0} must be at least {2} characters long.",MinimumLength =6 )]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}