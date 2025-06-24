using _43Conncted.Models;
using Microsoft.Data.SqlClient;

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
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string selectQuery = "SELECT * FROM Emp";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = selectQuery;
                    cmd.Connection = con;

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Emp emp = new Emp();
                            //emp.Id = reader.GetInt32(0);
                            //emp.Name = reader.GetString(1);
                            //emp.Address = reader.GetString(2);

                            emp.Id = Convert.ToInt32(reader["Id"]);
                            emp.Name = reader["Name"].ToString();
                            emp.Address = reader["Address"].ToString();

                            emps.Add(emp);
                        }
                    }
                }
            }

            return emps;
        }

        public int InsertRecords(string name, string address)
        {
            // This method will be used to insert records into the database.
            // It will use the connection string to connect to the database and execute a SQL query.
            // The results will be returned as a list of objects.
            // Implementation goes here...
            int rowsAffected = 0;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string insertQuery = "INSERT INTO Emp (Name, Address) VALUES (@Name, @Address)";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = insertQuery;
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Address", address);
                 
                    cmd.Connection = con;

                    con.Open();

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected; // Placeholder return value
        }

        public int UpdateRecords(int id, string name, string address)
        {
            // This method will be used to update records into the database.
            // It will use the connection string to connect to the database and execute a SQL query.
            // Implementation goes here...
            int rowsAffected = 0;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string updateQuery = "UPDATE Emp SET Name = @Name, Address = @Address WHERE Id = @Id";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = updateQuery;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Connection = con;
                    con.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected; // Placeholder return value
        }
        public int DeleteRecords(int id)
        {
            int rowsAffected = 0;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string deleteQuery = "DELETE FROM Emp WHERE Id = @Id";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = deleteQuery;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Connection = con;
                    // Open the connection and execute the command
                    con.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected; // Placeholder return value
        }
    }
}
