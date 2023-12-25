using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Windows_Form_Final___Tedshop_System.BusinessObjects;


namespace Windows_Form_Final___Tedshop_System.DataAcess
{
    internal class AppDBContext : DbContext
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
    }
}
