using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataloggingSystem.Classes
{
    class SqlManager
    {
        public SqlManager()
        {
        }

        public void StoreSensorData(float value, string tagName, string tagStatus)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;

            //try

            //{
            //Connect to database
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("SaveTagData", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@TagName", tagName));
            cmd.Parameters.Add(new SqlParameter("@TagValue", value));
            cmd.Parameters.Add(new SqlParameter("@TagStatus", tagStatus));

            cmd.ExecuteNonQuery();

            // Disconnect from database
            con.Close();
            //}
            //catch
            //{
            //throw new Exception("Error occurred trying to connect to the database");
            //}
        }

        public void ClearDataDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;

            try
            {
                // Connect to database
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                string query = "DELETE FROM TAGDATA";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                // Disconnect from database
                con.Close();
            }
            catch
            {
                throw new Exception("Error occurred trying to connect to the database");
            }
        }
    }
}