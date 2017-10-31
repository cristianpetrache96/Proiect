using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proiect_TP.DBContext;
using Proiect_TP.Models;

namespace Proiect_TP.DAL
{
    public class UserDAL
    {
        private static Context _context = new Context();

        internal bool AddUser(User user)
        {
            try
            {
                _context = new Context();
                _context.User.Add(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<User> GetUsers()
        {
            try
            {
                _context = new Context();
                return _context.User.ToList();
                
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}