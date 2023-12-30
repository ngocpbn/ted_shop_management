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
        public List<Product> SearchProductSByNameSizeCate(string name, string size = "", string cate = "") 
            => AppDBContext.Instance.SearchProductSByNameSizeCate(name, size, cate);
        // TO SEARCH BY NAME, USE THIS SYNTAX:
        // SearchProductSByNameSizeCate("teddy"); OR SearchForProductsByName("teddy");

        // TO SEARCH BY NAME AND SIZE, USE THIS SYNTAX:
        // SearchProductSByNameSizeCate(name: "teddy", size: "M"); --> use named parameters

        // TO SEARCH BY NAME AND CATEGORY, USE THIS SYNTAX:
        // SearchProductSByNameSizeCate(name: "teddy", cate: "Cat");

        // TO SEARCH BY NAME, SIZE, AND CATEGORY, USE THIS SYNTAX:
        // SearchProductSByNameSizeCate(name: "teddy", size: "M", cate: "Cat");
        public List<Product> GetAllProducts() => AppDBContext.Instance.GetAllProducts();
        public Product? GetProductByID(int productID) => AppDBContext.Instance.GetProductByID(productID);
        public List<Product> SearchForProductsByName(string name) => AppDBContext.Instance.SearchForProductsByName(name);
        public int AddNewProduct(Product product) => AppDBContext.Instance.AddNewProduct(product);
        public int UpdateExistingProduct(Product product) => AppDBContext.Instance.UpdateExistingProduct(product);  
        public int DeleteProducts(List<Product> products) => AppDBContext.Instance.DeleteProducts(products); 
        //Can delete many bears at once
    }
}
