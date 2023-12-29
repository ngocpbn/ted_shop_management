using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Form_Final___Tedshop_System.BusinessObjects;
using Windows_Form_Final___Tedshop_System.DataAcess;

namespace Windows_Form_Final___Tedshop_System.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        public List<Supplier> GetAllSuppliers() => AppDBContext.Instance.GetAllSuppliers();
        public Supplier? GetSupplierByID(int id) => AppDBContext.Instance.GetSupplierByID(id);
        public List<Supplier> SearchForSupplierByName(string name) => AppDBContext.Instance.SearchForSupplierByName(name);   
        public int AddNewSupplier(Supplier supplier) => AppDBContext.Instance.AddNewSupplier(supplier);
        public int UpdateSupplier(Supplier supplier) => AppDBContext.Instance.UpdateSupplier(supplier); 
        public int DeleteSupplier(Supplier supplier) => AppDBContext.Instance.DeleteSupplier(supplier);
    }
}
