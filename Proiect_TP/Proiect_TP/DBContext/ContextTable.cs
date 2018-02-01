using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Proiect_TP.Models;

namespace Proiect_TP.DBContext
{
    public class ContextTable:DbContext
    {
        public ContextTable() : base("defaultConnection")
        {

        }
        public DbSet<ChessTable> ChessTable { get; set; }
    }
}