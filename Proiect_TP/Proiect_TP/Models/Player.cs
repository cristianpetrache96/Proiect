using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_TP.Models
{
    public class Player
    {
        private User _user;
        private Side _side;

        public Player(User user, Side side)
        {
            _side = side;
            _user = user;
        }

        public Player(Side side)
        {
            _side = side;
        }


    }
}