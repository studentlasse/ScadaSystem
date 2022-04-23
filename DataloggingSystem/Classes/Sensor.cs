using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataloggingSystem.Classes
{
    class Sensor
    {
        public string SensorName { get; set; }

        public Sensor()
        {
            SensorName = "TC-01";
        }

        public void StoreSensorData(float measurement)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;

            try
            {
                // Connect to database
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("SaveMeasurementData", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@SensorName", SensorName));
                cmd.Parameters.Add(new SqlParameter("@MeasurementValue", measurement));

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
