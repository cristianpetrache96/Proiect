using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Proiect_TP.Models;

namespace Proiect_TP.DBContext
{
    public class Context:DbContext
    {
        public Context():base("defaultConnection")
        {
            
        }

        public DbSet<User> User { get; set; }
        public DbSet<Score> Score { get; set; }
        public DbSet<ChessGameLobby> ChessGameLobby { get; set; }
    }
}