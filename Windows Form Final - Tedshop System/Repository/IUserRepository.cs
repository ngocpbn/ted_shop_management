﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Form_Final___Tedshop_System.BusinessObjects;
using Windows_Form_Final___Tedshop_System.DataAcess;

namespace Windows_Form_Final___Tedshop_System.Repository
{
    public interface IUserRepository
    {
        List<Users> GetAllUsers();
        int Login(Users user);
        int Register(Users user);
        int UpdateUser(Users user);
        int DeleteUser(Users user);
    }
}
