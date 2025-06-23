using Microsoft.Data.SqlClient;
using System.Data;

namespace _44Disconnected
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=IETDb;Integrated Security=True";

            SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Emp", con);

            DataSet ds = new DataSet();
            da.Fill(ds,"Emp");
            //da.Fill(ds,"Employee");

            //ds.WriteXml("Emp.xml", XmlWriteMode.WriteSchema);

            var tb = ds.Tables["Emp"];

            foreach (DataRow row in tb.Rows)
            {
                int id  = Convert.ToInt32(row["Id"]);
                string name = row["Name"].ToString();
                string address = row["Address"].ToString();
                Console.WriteLine($"Id = {id}, Name = {name}, Address = {address}");
            }


            //Console.WriteLine("done");
        }
    }
}
