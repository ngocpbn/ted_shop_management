using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Form_Final___Tedshop_System.BusinessObjects;

namespace Windows_Form_Final___Tedshop_System.Repository
{
    public interface ISupplierRepository
    {
        List<Supplier> GetAllSuppliers();
        Supplier? GetSupplierByID(int id);
        List<Supplier> SearchForSupplierByName(string name);
        int AddNewSupplier(Supplier supplier);
        int UpdateSupplier(Supplier supplier);
        int DeleteSupplier(Supplier supplier);
    }
}
