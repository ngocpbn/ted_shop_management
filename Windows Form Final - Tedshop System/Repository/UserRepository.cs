using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Form_Final___Tedshop_System.BusinessObjects;
using Windows_Form_Final___Tedshop_System.DataAcess;

namespace Windows_Form_Final___Tedshop_System.Repository
{
    public class UserRepository : IUserRepository
    {

        public int Login(Users user) => AppDBContext.Instance.Login(user);
        int IUserRepository.Register(Users user) => AppDBContext.Instance.Register(user);
        int IUserRepository.UpdateUser(Users user) => AppDBContext.Instance.UpdateUser(user);
        int IUserRepository.DeleteUser(Users user) => AppDBContext.Instance.DeleteUser(user);
    }
}

