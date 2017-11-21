using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_TP.Models
{
    public class Player:User
    {
        
        private Side _side;

        public Player( Side side)
        {
            _side = side;
        
        }
    }
}