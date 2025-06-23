using Microsoft.Data.SqlClient;

namespace _42AdoNet_Connected
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=IETDb;Integrated Security=True";

            SqlConnection con = new SqlConnection(conStr);

            #region SELECT * FROM Emp 
            //SqlCommand cmd  = new SqlCommand("SELECT * FROM Emp", con);

            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader(); // it fires only select query // Factory method

            //while(reader.Read())
            //{
            //    //int id =Convert.ToInt32(reader[0]);
            //    //string nm = reader[1].ToString();
            //    //string add = reader[2].ToString();
            //    int id = Convert.ToInt32(reader["Id"]);
            //    // Using column names instead of indices for better readability
            //    string nm = reader["Name"].ToString();
            //    string add = reader["Address"].ToString();
            //    Console.WriteLine($"Id = {id}, Name = {nm}, Address = {add}");
            //}
            //con.Close(); // Close the connection 
            #endregion

            #region Insert Record
            //string insertQuery = "INSERT INTO Emp VALUES(5,'Tom Hanks','Sikkim')";
            //SqlCommand cmd = new SqlCommand(insertQuery, con);

            //con.Open();
            //int rowsAffected = cmd.ExecuteNonQuery(); // it fires insert, update, delete queries

            //con.Close(); // Close the connection
            //if (rowsAffected > 0)
            //{
            //    Console.WriteLine($"{rowsAffected} row(s) inserted successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("No rows were inserted.");
            //}
            #endregion

            #region Update Record
            //Console.WriteLine("Enter Id to be updated : ");
            //int id = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name to be updated : ");
            //string nm = Console.ReadLine();

            //Console.WriteLine("Enter Address to be updated : ");
            //string add = Console.ReadLine();

            //string updateQuery = $"UPDATE Emp SET Name = '{nm}', Address = '{add}' WHERE Id= {id}";
            //SqlCommand cmd = new SqlCommand(updateQuery, con);

            //con.Open();
            //int rowsAffected = cmd.ExecuteNonQuery(); // it fires insert, update, delete queries

            //con.Close(); // Close the connection
            //if (rowsAffected > 0)
            //{
            //    Console.WriteLine($"{rowsAffected} row(s) updated successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("No rows were updated.");
            //}
            #endregion

            #region Delete Record
            //Console.WriteLine("Enter Id to be deleted : ");
            //int id = Convert.ToInt32(Console.ReadLine());

            //string deleteQuery = $"DELETE FROM Emp WHERE Id = {id}";

            ////SqlCommand cmd = new SqlCommand(deleteQuery, con);
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = deleteQuery; // Setting the command text explicitly
            //cmd.CommandType = System.Data.CommandType.Text; // Setting the command type
            //cmd.Connection = con; // Assigning the connection to the command

            //con.Open();
            //int rowsAffected = cmd.ExecuteNonQuery(); // it fires insert, update, delete queries

            //con.Close(); // Close the connection
            //if (rowsAffected > 0)
            //{
            //    Console.WriteLine($"{rowsAffected} row(s) deleted successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("No rows were deleted.");
            //}
            #endregion
        }
    }
}
