using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proiect_TP.Models;
using Proiect_TP.DAL;
using Proiect_TP.Proiect_TP.DAL;

namespace Proiect_TP.BLL
{
    public class ScoreBLL
    {

        ScoreDAL scoreDAL = new ScoreDAL();

        internal bool Addscore(Score score)
        {
            return scoreDAL.AddScore(score);
        }

        public List<Score> GetScores()
        {
            return scoreDAL.GetScores();
        }

    }
}
}