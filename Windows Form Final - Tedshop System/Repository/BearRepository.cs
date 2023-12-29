using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Form_Final___Tedshop_System.BusinessObjects;
using Windows_Form_Final___Tedshop_System.DataAcess;

namespace Windows_Form_Final___Tedshop_System.Repository
{
    public class BearRepository : IBearRepository
    {
        public List<Product> GetAllProducts() => AppDBContext.Instance.GetAllProducts();
        public Product? GetProductByID(int productID) => AppDBContext.Instance.GetProductByID(productID);
        public List<Product> SearchForProductsByName(string name) => AppDBContext.Instance.SearchForProductsByName(name);
        public int AddNewProduct(Product product) => AppDBContext.Instance.AddNewProduct(product);
        public int UpdateExistingProduct(Product product) => AppDBContext.Instance.UpdateExistingProduct(product);  
        public int DeleteProducts(List<Product> products) => AppDBContext.Instance.DeleteProducts(products); 
        //Can delete many bears at once
    }
}
