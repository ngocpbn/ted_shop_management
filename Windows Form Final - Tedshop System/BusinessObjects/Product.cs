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
        public int Product_ID { get; set; }


        [StringLength(20)]
        public string Name { get; set; } = "";

        [StringLength(30)]
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0.0m;
        public int Stock { get; set; } = 0;
        public int Supplier_ID { get; set; } = 0;

        [StringLength(10)]
        public string Size { get; set; } = string.Empty;

        [StringLength(30)]
        public string Category { get; set; } = string.Empty;
    }
}