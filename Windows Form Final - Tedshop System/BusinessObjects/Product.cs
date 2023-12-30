using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Form_Final___Tedshop_System.BusinessObjects
{
    public class Product
    {
        [Key]
        public int Product_ID {  get; set; }


        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(30)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int Supplier_ID { get; set; }
    }
}
