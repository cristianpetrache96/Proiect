using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proiect_TP.Models

{
    [Table("Score")]
    public class Score
    {
        [Key,Required]
        public Guid id { get; set; }

        public List<long> scor_list{get; set;}



    }
}