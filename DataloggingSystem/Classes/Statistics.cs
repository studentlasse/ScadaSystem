using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggingSystem.Classes
{
    class Statistics
    {
        public string SensorName { get; set; }

        public Statistics()
        {
            this.SensorName = "TC-01";
        }

        public StatisticsData GetStatisticsData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;

            float average = 0;
            float minMeasurement = 0;
            float maxMeasurement = 0;

            try
            { 

                // Connect to database
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                string selectSQL = "SELECT Average, MaxMeasurement, MinMeasurement FROM GetStatistics WHERE SensorName = @SensorName";

                SqlCommand cmd = new SqlCommand(selectSQL, con);
                cmd.Parameters.Add(new SqlParameter("@SensorName", SensorName));
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        average = (float) Convert.ToDouble(dr["Average"]);
                        minMeasurement = (float) Convert.ToDouble(dr["MinMeasurement"]);
                        maxMeasurement = (float) Convert.ToDouble(dr["MaxMeasurement"]);
                    }
                }

                // Disconnect from database
                con.Close();
            }
            catch
            {
                throw new Exception("Error occurred trying to connect to the database");
            }

            return new StatisticsData(average, minMeasurement, maxMeasurement);
        }
    }
}
