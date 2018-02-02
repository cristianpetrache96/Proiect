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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
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
                log.Info(ex.StackTrace);
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
                log.Info(ex.StackTrace);
                return null;
            }
        }

        internal User GetUserByEmailPass(User user)
        {
            _context = new Context();
            return _context.User.FirstOrDefault(item => item.Name == user.Name && item.Password == user.Password);
        }

        internal bool CheckPassword(String name, String pass)
        {
            _context = new Context();
            return _context.User.Any(item => item.Name == name && item.Password == pass);
        }
        internal User GetUserById(Guid Id)
        {
            _context = new Context();
            return _context.User.FirstOrDefault(item => item.Id == Id);
        }
    }
}