﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proiect_TP.Models;
using Proiect_TP.DAL;

namespace Proiect_TP.BLL
{
    public class UserBLL
    {

        UserDAL userDAL = new UserDAL();

        internal bool AddUser(User user)
        {
            return userDAL.AddUser(user);
        }

        public List<User> GetUsers()
        {
            return userDAL.GetUsers();
        }

    }
}