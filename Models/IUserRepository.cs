﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OptiCare.Models
{
    public interface IUserRepository
    {
        bool AuthenticateUser(NetworkCredential credential);
        void Add(UserModel userModel);
        void Edit(UserModel UserModel);
        void Remove(int id);

        UserModel GetById(int id);
        UserModel GetByUsername(string username);
        IEnumerable<UserModel> GetAll();
    }
}
