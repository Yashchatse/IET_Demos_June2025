using _45EntityFramework.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace _45EntityFramework.DAL
{
    internal class IETDbContext :DbContext
    {
        public DbSet<Customer> custs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // A service to read appsettings.json file
            var builder = new  ConfigurationBuilder();

            //string dirPath = Directory.GetCurrentDirectory();//// Path =" /bin/debug/net8.0" 
            builder.SetBasePath(Directory.GetCurrentDirectory());

            // Add the JSON file to the configuration and copy appsettings.json file to the output directory
            builder.AddJsonFile("appsettings.json");

            // Build the configuration
            IConfiguration configuration = builder.Build();

            //Database Provider -  service register
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("conStr"));
        }

        public Customer GetCustomerById(int id)
        {
            var idSQLParameter =new SqlParameter("@Id", id);
            // Execute the stored procedure
            var customer = custs.FromSqlRaw("EXEC GetCustomerById @Id", idSQLParameter).ToList().FirstOrDefault();
            return customer;
        }
    }
}
