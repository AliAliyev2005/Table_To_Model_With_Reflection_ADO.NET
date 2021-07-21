using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_2_ADO.NET.Model
{
    public static class DataReader
    {
        public static List<Customer> GetData(string tableName)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerDatabase"].ConnectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand()
                {
                    Connection = con,
                    CommandText = $"SELECT * FROM {tableName}"
                };

                SqlDataReader data = command.ExecuteReader();

                Type type = new Customer().GetType();

                List<Customer> customers = new List<Customer>();

                List<string> properties = new List<string>();

                foreach (var p in type.GetProperties()) properties.Add(p.Name);

                while (data.Read())
                {
                    customers.Add
                        (
                            new Customer()
                            {
                                FisrtName = data[properties[0]] as string,
                                LastName = data[properties[1]] as string,
                                Phone = data[properties[2]] as string,
                                Email = data[properties[3]] as string,
                                Birthdate = Convert.ToDateTime(data[properties[4]]),
                                City = data[properties[5]] as string,
                                ZipCode = (int)data[properties[6]],
                            }
                        );
                }

                return customers;
            }
        }
    }
}
