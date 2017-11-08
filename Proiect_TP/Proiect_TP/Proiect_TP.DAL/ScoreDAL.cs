using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proiect_TP.DBContext;
using Proiect_TP.Models;


namespace Proiect_TP.Proiect_TP.DAL
{
    public class ScoreDAL
    {
        private static Context _context = new Context();
        internal bool AddScore(Score score)
        {
            try
            {
                _context = new Context();
                _context.Score.Add(score);
                _context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public List<Score> GetScores()
        {
            try
            {
                _context = new Context();
                return _context.Score.ToList();
            }

            catch (Exception ex)
            {
                return null;
            }
    }
}