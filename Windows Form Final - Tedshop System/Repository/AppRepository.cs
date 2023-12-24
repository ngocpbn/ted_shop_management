using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Form_Final___Tedshop_System.DataAcess;

namespace Windows_Form_Final___Tedshop_System.Repository
{
    public class AppRepository : IAppRepository
    {
        public int Login(string username, string password) => AppDBContext.Instance.Login(username, password);
    }
}

