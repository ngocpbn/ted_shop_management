using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Form_Final___Tedshop_System.BusinessObjects;

namespace Windows_Form_Final___Tedshop_System.Repository
{
    public interface IBearRepository
    {
        List<Product> SearchProductSByNameSizeCate(string name, string size = "", string cate = "");
        List<Product> GetAllProducts();

        Product? GetProductByID(int productID);
        List<Product> SearchForProductsByName(string name);
        int AddNewProduct(Product product);
        int UpdateExistingProduct(Product product);
        int DeleteProducts(List<Product> products);
    }
}
