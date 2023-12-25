using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Data.SqlClient;
using Windows_Form_Final___Tedshop_System.BusinessObjects;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Windows_Form_Final___Tedshop_System.DataAcess
{
    public class AppDBContext : DbContext
    {
        SqlConnection _connection;
        SqlCommand _command;
        


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
        private static AppDBContext instance = null;
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

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }

        public int Login(string username, string password) { 
            _connection = new SqlConnection(ConnectionString());  
            string query = "select u_fullname, u_password from Users where u_username = '" + username + " ' ";
        
            _command = new SqlCommand(query, _connection);
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }
                SqlDataReader reader = _command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader["u_password"].Equals(password))
                    {
                        SearchForProductsByName("teddy");
                        return 200; // Login Successful
                    }
                    else
                    {
                        return -1; // Incorrect password
                    }
                }
                else
                {
                    return -2; // Incorrect username
                }
            }
            catch (Exception ex) {
                _connection.Close();
                return -3; // Connection Error
            }
        }

        public List<Product> GetAllProducts()
        {
            List<Product> allProducts = new List<Product>();
            _connection = new SqlConnection(ConnectionString());
            string query = "select * from Product";
            _command = new SqlCommand(query, _connection);
            SqlDataReader reader;
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }
                reader = _command.ExecuteReader();
            }

            catch
            {
                _connection.Close();
                return allProducts;
            }

            while (reader.Read())
            {

                Product product = new Product
                {
                    ProductID = reader.GetInt32("Product_ID"),
                    Name = reader.GetString("Name"),
                    Description = reader.GetString("Description"),
                    Price = reader.GetDecimal("Price"),
                    Stock = reader.GetInt32("Stock"),
                    SupplierID = reader.GetInt32("Supplier_ID")
                };
                allProducts.Add(product);
            }
            _connection.Close();
            return allProducts;
        }

        public Product GetProductByID(int productID)
        {
            _connection = new SqlConnection(ConnectionString());
            string query = $"select * from Product where Product_ID = {productID}";
            _command = new SqlCommand(query, _connection);
            SqlDataReader reader;
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }
                reader = _command.ExecuteReader();
            }catch
            {
                _connection.Close();
                return new Product();
            }

            Product product = new Product();
             while (reader.Read())
            {

                 product = new Product
                {
                    ProductID = reader.GetInt32("Product_ID"),
                    Name = reader.GetString("Name"),
                    Description = reader.GetString("Description"),
                    Price = reader.GetDecimal("Price"),
                    Stock = reader.GetInt32("Stock"),
                    SupplierID = reader.GetInt32("Supplier_ID")
                };
               
            }
            _connection.Close();
            return product;
        }

        public List<Product> SearchForProductsByName(string name)
        {
            List<Product> allProducts = new List<Product>();
            _connection = new SqlConnection(ConnectionString());
            string query = $"select * from Product where Name like '%{name}%'" ;
            _command = new SqlCommand(query, _connection);
            SqlDataReader reader;
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }
                reader = _command.ExecuteReader();
            }
            catch
            {
                _connection.Close();
                return allProducts;
            }

            while (reader.Read())
            {

                Product product = new Product
                {
                    ProductID = reader.GetInt32("Product_ID"),
                    Name = reader.GetString("Name"),
                    Description = reader.GetString("Description"),
                    Price = reader.GetDecimal("Price"),
                    Stock = reader.GetInt32("Stock"),
                    SupplierID = reader.GetInt32("Supplier_ID")
                };
                allProducts.Add(product);
            }
            _connection.Close();
            return allProducts;
        }


    }
}
