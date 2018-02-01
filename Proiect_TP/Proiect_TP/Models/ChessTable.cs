using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Proiect_TP.Models
{
    [Table("ChessTable")]
    public class ChessTable
    {
        [Key, Required]
        public Guid Id { get; set; }

        public String A1{ get; set; }
        public String A2{ get; set; }
        public String A3{ get; set; }
        public String A4{ get; set; }
        public String A5{ get; set; }
        public String A6{ get; set; }
        public String A7{ get; set; }
        public String A8{ get; set; }
               
        public String B1{ get; set; }
        public String B2{ get; set; }
        public String B3{ get; set; }
        public String B4{ get; set; }
        public String B5{ get; set; }
        public String B6{ get; set; }
        public String B7{ get; set; }
        public String B8{ get; set; }
               
        public String C1{ get; set; }
        public String C2{ get; set; }
        public String C3{ get; set; }
        public String C4{ get; set; }
        public String C5{ get; set; }
        public String C6{ get; set; }
        public String C7{ get; set; }
        public String C8{ get; set; }
               
        public String D1{ get; set; }
        public String D2{ get; set; }
        public String D3{ get; set; }
        public String D4{ get; set; }
        public String D5{ get; set; }
        public String D6{ get; set; }
        public String D7{ get; set; }
        public String D8{ get; set; }
               
        public String E1{ get; set; }
        public String E2{ get; set; }
        public String E3{ get; set; }
        public String E4{ get; set; }
        public String E5{ get; set; }
        public String E6{ get; set; }
        public String E7{ get; set; }
        public String E8{ get; set; }
               
        public String F1{ get; set; }
        public String F2{ get; set; }
        public String F3{ get; set; }
        public String F4{ get; set; }
        public String F5{ get; set; }
        public String F6{ get; set; }
        public String F7{ get; set; }
        public String F8{ get; set; }
               
        public String G1{ get; set; }
        public String G2{ get; set; }
        public String G3{ get; set; }
        public String G4{ get; set; }
        public String G5{ get; set; }
        public String G6{ get; set; }
        public String G7{ get; set; }
        public String G8{ get; set; }
               
        public String H1{ get; set; }
        public String H2{ get; set; }
        public String H3{ get; set; }
        public String H4{ get; set; }
        public String H5{ get; set; }
        public String H6{ get; set; }
        public String H7{ get; set; }
        public String H8{ get; set; }




    }
}