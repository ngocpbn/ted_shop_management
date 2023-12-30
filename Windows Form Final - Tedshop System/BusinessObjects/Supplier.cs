using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Form_Final___Tedshop_System.BusinessObjects
{
    public class Supplier
    {
        [Key]
        public int Supplier_ID { get; set; }

        [StringLength(20)]
        public string Name { get; set; } = string.Empty;

        [StringLength(25)]
        public string Phone_num { get; set;}

        [StringLength(20)]
        public string Email { get; set;}

        [StringLength(30)]
        public string Address { get; set;}
    }
}
