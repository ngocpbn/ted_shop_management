using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Form_Final___Tedshop_System.BusinessObjects
{
    public class Users
    {
        public int? UserID { get; set; } 
        public string? FullName { get; set; }    
        public  int? Age { get; set; }
        public string? Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
