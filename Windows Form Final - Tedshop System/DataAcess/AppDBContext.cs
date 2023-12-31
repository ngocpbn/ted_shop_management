using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Windows_Form_Final___Tedshop_System.BusinessObjects;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Windows_Form_Final___Tedshop_System.DataAcess
{
    public class AppDBContext : DbContext
    {
        static string ConnectionString()
        {
            string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["TedShopDB"].ConnectionString;
            return ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString());
        }

        // Use Singleton pattern
        private static AppDBContext? instance = null;
        private static readonly object instanceLock = new object();
        private AppDBContext() { }
        public static AppDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AppDBContext();
                    }
                    return instance;
                }
            }
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        public List<Users> GetAllUsers()
        {
            try
            {
                return Instance.Users.ToList();

            }catch (Exception ex) {
                MessageBox.Show("Errow while retrieving data. See log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return new List<Users>() ;
            }
        }
        public int Login(Users user) {
            Users usr;
            try
            {
                usr = Instance.Users.Single(u => u.u_username.Equals(user.u_username));
            }
            catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return -2;      // Incorrect username
            }

            if (usr.u_password.Equals(user.u_password))
            {
                return 200;     // Login Successful
            }

            return -1;  // Incorrect password
        }

        public int Register(Users user)
        {
            try
            {
                Instance.Users.Add(user);
                Instance.SaveChanges();
            }
            catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return -1;
            }

            return 1;
        }

        public int UpdateUser(Users user)
        {
            try
            {
                Instance.Users.Update(user);
                Instance.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return -1;
            }
            return 1;
        }

        public int DeleteUser(Users user)
        {
            try
            {
                Instance.Users.Remove(user);
                Instance.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return -1;
            }
            return 1;
        }
        
        public List<Product> GetAllProducts() {
            try
            {
                return Instance.Product.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errow while retrieving data. See log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return new List<Product>();
            }
        
        }
        public Product? GetProductByID(int productID)
        {
            try
            {
                return Instance.Product.Single(product => product.Product_ID == productID); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errow while retrieving data. See log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public List<Product> SearchForProductsByName(string name) => Instance.Product.Where(product => product.Name.Contains(name)).ToList();

        public List<Product> SearchProductSByNameSizeCate (string name, string size = "", string cate = "") {
           
            if (size == "" && cate == "")
            {
                return SearchForProductsByName(name);
            }
            if (size != "" && cate == "")
            {
                return Instance.Product.Where(product => product.Name.Contains(name) && product.Size.Contains(size)).ToList(); ;
            }
            if (cate != "" && size == "")
            {
                return Instance.Product.Where(product => product.Name.Contains(name) && product.Category.Contains(cate)).ToList(); ;
            }

            return Instance.Product.Where(product => product.Name.Contains(name) && product.Size.Contains(size) && product.Category.Contains(cate)).ToList();
        }
        public int AddNewProduct(Product product)
        {
            try
            {
                Instance.Product.Add(product);      /*Equivalent to command.ExecuteNonQuery(); with sql is insert into Product (Name,Description,Price,Stock,Supplier_ID) values (@name, @description, @price, @stock, @supplier_ID)*/
                Instance.SaveChanges();             /*Push the changes to the db*/
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                if (e.InnerException != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Inner exception: {e.InnerException.Message}");
                }
                return -1;
            }

            return 1;
        }

        public int UpdateExistingProduct(Product product)
        {
            try
            {
                Instance.Product.Update(product);
                Instance.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return -1;
            }
            return 1; /*Updated record successfully*/
        }

        public int DeleteProducts(List<Product> products)
        {
            try
            {
                foreach (Product product in products)
                {
                    Instance.Product.Remove(product);
                }

                Instance.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return -1;
            }
            return 1;
        }

        public List<Supplier> GetAllSuppliers()
        {
            try
            {
                return Instance.Supplier.ToList();
            }
            catch (Exception ex) {
                MessageBox.Show("Errow while retrieving data. See log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return new List<Supplier>();
            }
        }
        public Supplier? GetSupplierByID(int id)
        {
            try
            {
                return Instance.Supplier.Single(supplier => supplier.Supplier_ID.Equals(id));
            }
            catch (Exception e) {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }
        public List<Supplier> SearchForSupplierByName(string name)  => Instance.Supplier.Where(supplier => supplier.Name.Contains(name)).ToList();
        public int AddNewSupplier(Supplier supplier) {
            try
            {
                Instance.Supplier.Add(supplier);
                Instance.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return -1;
            }
            return 1;
        }

        public int UpdateSupplier(Supplier supplier) {
            try
            {
                Instance.Supplier.Update(supplier);
                Instance.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return -1;
            }
            return 1;
        }

        public int DeleteSupplier(Supplier supplier)
        {
            try
            {
                Instance.Supplier.Remove(supplier);
                Instance.SaveChanges(); 
            }
            catch (Exception e) {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return -1;
            }
            return 1;
        }
    }
}



/*OLD WAYS OF QUERY. REFERENCE PURPOSES ONLY*/

//public int AddNewProduct(Product product)
//{
//    /*You should check if the input fields exceed allowed number of character*//*
//    if (product.Name.Length > 20 || product.Description.Length > 30)
//    {
//        System.Diagnostics.Debug.WriteLine($"Name field and Description field should have maximum of 20 and 30 characters respectively. length of name field is {product.Name.Length}, length of Description is {product.Description.Length}");
//        return -2;
//    }
//    *//*Since supplier ID is referenced from Supplier table, you need to check whether the chosen supplier ID exists in the table or not*//*
//    SqlConnection _connection = new SqlConnection(ConnectionString());
//    string query = $"insert into Product (Name,Description,Price,Stock,Supplier_ID) values (@name, @description, @price, @stock, @supplier_ID)";

//    SqlCommand _command = new SqlCommand(query, _connection);
//    _command.Parameters.AddWithValue("@name", product.Name);
//    _command.Parameters.AddWithValue("@description", product.Description);
//    _command.Parameters.AddWithValue("@price", product.Price);
//    _command.Parameters.AddWithValue("@stock", product.Stock);
//    _command.Parameters.AddWithValue("@supplier_ID", product.SupplierID);
//    try
//    {
//        _connection.Open();
//        _command.ExecuteNonQuery();
//    }
//    catch (Exception ex)
//    {
//        System.Diagnostics.Debug.WriteLine(ex.Message);
//        _connection.Close();
//        return -1;
//    }

//    _connection.Close();
//    return 1; *//*Added to db successfully*/
//}

//public List<Product> GetAllProducts()
//{

//    List<Product> allProducts = new List<Product>();
//    SqlConnection _connection = new SqlConnection(ConnectionString());
//    string query = "select * from Product";
//    SqlCommand _command = new SqlCommand(query, _connection);
//    SqlDataReader reader;
//    try
//    {
//        if (_connection.State == ConnectionState.Closed)
//        {
//            _connection.Open();
//        }
//        reader = _command.ExecuteReader();
//    }

//    catch (Exception ex)
//    {
//        System.Diagnostics.Debug.WriteLine(ex.Message);
//        _connection.Close();
//        return allProducts;
//    }

//    while (reader.Read())
//    {

//        Product product = new Product
//        {
//            Product_ID = reader.GetInt32("Product_ID"),
//            Name = reader.GetString("Name"),
//            Description = reader.GetString("Description"),
//            Price = reader.GetDecimal("Price"),
//            Stock = reader.GetInt32("Stock"),
//            Supplier_ID = reader.GetInt32("Supplier_ID")
//        };
//        allProducts.Add(product);
//    }
//    _connection.Close();
//    return allProducts;
//}

//public Product GetProductByID(int productID)
//{
//    SqlConnection _connection = new SqlConnection(ConnectionString());
//    string query = $"select * from Product where Product_ID = {productID}";
//    SqlCommand _command = new SqlCommand(query, _connection);
//    SqlDataReader reader;
//    try
//    {
//        if (_connection.State == ConnectionState.Closed)
//        {
//            _connection.Open();
//        }
//        reader = _command.ExecuteReader();
//    }
//    catch (Exception ex)
//    {
//        System.Diagnostics.Debug.WriteLine(ex.Message);
//        _connection.Close();
//        return new Product();
//    }

//    Product product = new Product();
//    while (reader.Read())
//    {

//        product = new Product
//        {
//            Product_ID = reader.GetInt32("Product_ID"),
//            Name = reader.GetString("Name"),
//            Description = reader.GetString("Description"),
//            Price = reader.GetDecimal("Price"),
//            Stock = reader.GetInt32("Stock"),
//            Supplier_ID = reader.GetInt32("Supplier_ID")
//        };

//    }
//    _connection.Close();
//    return product;
//}


//public List<Product> SearchForProductsByName(string name)
//{
//    List<Product> allProducts = new List<Product>();
//    SqlConnection _connection = new SqlConnection(ConnectionString());
//    string query = $"select * from Product where Name like '%{name}%'";
//    SqlCommand _command = new SqlCommand(query, _connection);
//    SqlDataReader reader;
//    try
//    {
//        if (_connection.State == ConnectionState.Closed)
//        {
//            _connection.Open();
//        }
//        reader = _command.ExecuteReader();
//    }
//    catch (Exception ex)
//    {
//        System.Diagnostics.Debug.WriteLine(ex.Message);
//        _connection.Close();
//        return allProducts;
//    }

//    while (reader.Read())
//    {

//        Product product = new Product
//        {
//            Product_ID = reader.GetInt32("Product_ID"),
//            Name = reader.GetString("Name"),
//            Description = reader.GetString("Description"),
//            Price = reader.GetDecimal("Price"),
//            Stock = reader.GetInt32("Stock"),
//            Supplier_ID = reader.GetInt32("Supplier_ID")
//        };
//        allProducts.Add(product);
//    }
//    _connection.Close();
//    return allProducts;
//}

//public int UpdateExistingProduct(Product product)
//{
//    if (product.Name.Length > 20 || product.Description.Length > 30)
//    {
//        System.Diagnostics.Debug.WriteLine($"Name field and Description field should have maximum of 20 and 30 characters respectively. length of name field is {product.Name.Length}, length of Description is {product.Description.Length}");
//        return -2;
//    }
//    SqlConnection _connection = new SqlConnection(ConnectionString());
//    string query = $"Update Product set Name = @name, Description = @description , Price = @price ,Stock = @stock, Supplier_ID = @supplier_ID where Product_ID = @id";
//    SqlCommand _command = new SqlCommand(query, _connection);
//    _command.Parameters.AddWithValue("@id", product.Product_ID);
//    _command.Parameters.AddWithValue("@name", product.Name);
//    _command.Parameters.AddWithValue("@description", product.Description);
//    _command.Parameters.AddWithValue("@price", product.Price);
//    _command.Parameters.AddWithValue("@stock", product.Stock);
//    _command.Parameters.AddWithValue("@supplier_ID", product.Supplier_ID);
//    try
//    {
//        _connection.Open();
//        _command.ExecuteNonQuery();
//    }
//    catch (Exception ex)
//    {
//        System.Diagnostics.Debug.WriteLine(ex.Message);
//        _connection.Close();
//        return -1;
//    }

//    _connection.Close();
//    return 1; /*Updated record successfully*/
//}