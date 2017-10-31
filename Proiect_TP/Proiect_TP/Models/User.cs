using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proiect_TP.Models
{
    [Table("User")]
    public class User
    {
        [Key,Required]
        public Guid Id{ get; set; }

        public String Name { get; set; }

        [EmailAddress]
        public String Email { get; set; }

        public String Password { get; set; }
    }
}