using _43Conncted.Models;
using System.Data.SqlTypes;

namespace _43Conncted.DAL
{
    // Data Access Layer : Buissness Logic Layer : Repository Layer
    internal class IETDbContext 
    {
        // This class is responsible for managing the connection to the database.
        // It will be used by the repository classes to perform CRUD operations.
        // Connection string to connect to the database.
        // This should be stored in a secure place, not hardcoded in production code.
    
        string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=IETDb;Integrated Security=True";

        public List<Emp> SelectRecords()
        {
            // This method will be used to select records from the database.
            // It will use the connection string to connect to the database and execute a SQL query.
            // The results will be returned as a list of objects.
            List<Emp> emps = new List<Emp>();
            SqlConnection con = new SqlConnection(conStr);
        }
    }
}
