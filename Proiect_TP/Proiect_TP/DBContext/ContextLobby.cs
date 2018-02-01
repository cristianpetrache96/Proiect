using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Proiect_TP.Models;

namespace Proiect_TP.DBContext
{
    public class ContextLobby:DbContext
    {

        public ContextLobby():base("defaultConnection")
        {
        }
        public DbSet<ChessLobby> ChessLobby { get; set; }
    }
}