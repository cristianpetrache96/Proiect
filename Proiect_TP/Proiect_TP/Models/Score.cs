//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;

//namespace Proiect_TP.Models
//{
//    [Table("Score")]
//    public class Score
//    {
//        [Key,Required]
//        public Guid Scoreid { get; set; }
//        [ForeignKey ("User")]
//        public Guid Iduser { get; set; }
//        public List<int> ScoreList { get; set; }
//        public int Wins { get; set; }
//        public int Lose { get; set; }
   

//    }
//}