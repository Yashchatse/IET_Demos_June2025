using Microsoft.Data.SqlClient;

namespace _12Demo_AdoNETConnected.Models
{
    public class EmpDbContext
    {
        private string _connectionString;
        public EmpDbContext(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("conStr");
        }

        public List<Emp> GetEmpRecords()
        {
            List<Emp> empList = new List<Emp>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Emp";
                    cmd.Connection = con;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Emp emp = new Emp
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Address = reader["Address"].ToString(),
                            };
                            empList.Add(emp);
                        }
                       
                    }
                }
            }

            return empList;
        }
    }
}
