using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proiect_TP.Models
{
    [Table("ChessGameLobby")]
    public class ChessGameLobby
    {
        [Key, Required]
        public Guid Id { get; set; }
        public ChessGame _game { get; set; }
        public User user1 { get; set; }
        public User user2 { get; set; }

    }
}