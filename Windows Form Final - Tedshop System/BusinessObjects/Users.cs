using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Form_Final___Tedshop_System.BusinessObjects
{
    public class Users
    {
        [Key]
        public int? u_id { get; set; }

        [StringLength(50)]
        public string? u_fullname { get; set; }    
        public  int? u_age { get; set; }

        [StringLength(50)]
        public string? u_email { get; set; }

        [StringLength(50)]
        public string u_username { get; set; }

        [StringLength(50)]
        public string u_password { get; set; }
    }
}
