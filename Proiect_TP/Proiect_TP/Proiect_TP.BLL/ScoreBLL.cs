using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proiect_TP.Models;
using Proiect_TP.DAL;

namespace Proiect_TP.BLL
{
    public class ScoreBLL
    {
        
        ScoreDAL ScoreDAL = new ScoreDAL();
        internal bool AddScore(Score score)
        {
            return ScoreDAL.AddScore(score);
        }
        public List<Score> GetScore()
        {
            return ScoreDAL.GetScore();
        }
    }
}