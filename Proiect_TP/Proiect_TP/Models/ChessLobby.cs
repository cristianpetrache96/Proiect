using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proiect_TP.Models
{
    [Table("ChessLobby")]
    public class ChessLobby
    {
        [Key, Required]
        public Guid Id { get; set; }
        public Guid gameGUID { get; set; }
        public Guid user1GUID { get; set; }
        public Guid user2GUID { get; set; }
    }
}