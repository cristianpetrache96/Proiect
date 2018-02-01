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
        [Required,Key]
        public Guid Id;

        public string BlackPawn1;
        public string BlackPawn2;
        public string BlackPawn3;
        public string BlackPawn4;
        public string BlackPawn5;
        public string BlackPawn6;
        public string BlackPawn7;
        public string BlackPawn8;
        public string BlackRook1;
        public string BlackRook2;
        public string BlackKnight1;
        public string BlackKnight2;
        public string BlackBishop1;
        public string BlackBishop2;
        public string BlackQueen;
        public string BlackKing;

        public string WhitePawn1;
        public string WhitePawn2;
        public string WhitePawn3;
        public string WhitePawn4;
        public string WhitePawn5;
        public string WhitePawn6;
        public string WhitePawn7;
        public string WhitePawn8;
        public string WhiteRook1;
        public string WhiteRook2;
        public string WhiteKnight1;
        public string WhiteKnight2;
        public string WhiteBishop1;
        public string WhiteBishop2;
        public string WhiteQueen;
        public string WhiteKing;

    }
}