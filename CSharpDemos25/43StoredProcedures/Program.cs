using Microsoft.Data.SqlClient;
namespace _43StoredProcedures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InsertDepartment("Sales");
            InsertEmployee("Black Panther",4 );
            InsertEmployee("Doctor Strange",4 );

            GetEmployeeById(1);
            Console.WriteLine("--------------------------------");
            GetEmployeeById(2);
            Console.WriteLine("--------------------------------");
            GetEmployeeById(3);
            Console.WriteLine("--------------------------------");
            GetEmployeeById(4);
            Console.WriteLine("--------------------------------");
        }
        public static void InsertDepartment(string deptName)
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=IETDb;Integrated Security=True";
            // Example of inserting a department using a stored procedure
            using (var connection = new SqlConnection(conStr))
            {
                connection.Open();
                using (var command = new SqlCommand("InsertDepartment", connection))
                {
                    //command.CommandText = "InsertDepartment";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DepartmentName", deptName);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void InsertEmployee(string nm, int deptId)
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=IETDb;Integrated Security=True";
            // Example of inserting an employee using a stored procedure
            using (var connection = new SqlConnection(conStr))
            {
                connection.Open();
                using (var command = new SqlCommand("InsertEmployee", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeName", nm);
                    command.Parameters.AddWithValue("@DepartmentId",deptId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void GetEmployeeById(int id)
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=IETDb;Integrated Security=True";
            // Example of retrieving an employee by ID using a stored procedure
            using (var connection = new SqlConnection(conStr))
            {
                connection.Open();
                using (var command = new SqlCommand("GetEmployeeByDepartment", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DepartmentId", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["EmployeeId"]}, Name: {reader["EmployeeName"]}");
                        }
                    }
                }
            }
        }
        #region create stored procedure
        //public static void CreateStoredProcedure()
        //{
        //    using (var connection = new SqlConnection("YourConnectionStringHere"))
        //    {
        //        connection.Open();
        //        var command = new SqlCommand(
        //            "CREATE PROCEDURE GetEmployeeById @Id INT AS SELECT * FROM Employees WHERE Id = @Id",
        //            connection);
        //        command.ExecuteNonQuery();
        //    }
        //} 
        #endregion
    }
}
