using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_TP.Models
{
    public class Side
    {
        SideType _side;
        public enum SideType { White, Black };

        public Side()
        {

        }

        public Side(SideType side)
        {
            _side = side;
        }


        public SideType SideTip
        {
            get
            {
                return _side;
            }
        }

        public SideType Enemy()
        {
            if (this.SideTip == SideType.White)
                return SideType.Black;
            else return SideType.White; 
        }
    }
}