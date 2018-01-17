using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proiect_TP.Models
{
    [NotMapped]
    public class Player:User
    {
        
        private Side _side;

        public Player()
        {

        }

        public Player( Side side)
        {
            _side = side;
        
        }
    }
}