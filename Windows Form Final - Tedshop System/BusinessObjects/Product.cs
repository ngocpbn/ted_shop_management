using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Form_Final___Tedshop_System.BusinessObjects
{
    internal class Product
    {
        public int ProductID {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int SupplierID { get; set; }
    }
}
