using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace AlarmSystem.Model
{
    public class AlarmConfiguration
    {
        public int AlarmConfigId { get; set; }
        public string AlarmName { get; set; }
        public string AlarmDescription { get; set; }
        public int UpperLimit { get; set; }
        public int LowerLimit { get; set; }

        public int AlarmId { get; set; }

        public AlarmConfiguration GetAlarmConfiguration(string connectionString, int alarmConfigId)
        {
            AlarmConfiguration alarmConfiguration = new AlarmConfiguration();

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string sqlQuery = "";


            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            var alarmConfigIdParameter = new SqlParameter("alarmconfigid", System.Data.SqlDbType.Int);
            alarmConfigIdParameter.Value = alarmConfigId;
            cmd.Parameters.Add(alarmConfigIdParameter);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                alarmConfiguration.AlarmId = Convert.ToInt32(dr["AlarmId"]);
                alarmConfiguration.AlarmConfigId = Convert.ToInt32(dr["AlarmConfigurationId"]);
                alarmConfiguration.AlarmName = dr["Name"].ToString();
                alarmConfiguration.AlarmDescription = dr["Description"].ToString();
                alarmConfiguration.LowerLimit = Convert.ToInt32(dr["AlarmLowerLimit"]);
                alarmConfiguration.UpperLimit = Convert.ToInt32(dr["AlarmUpperLimit"]);
            }
            con.Close();
            return alarmConfiguration;
        }

        public List<AlarmConfiguration> GetAlarmConfigList(string connectionString)
        {
            List<AlarmConfiguration> alarmConfigList = new List<AlarmConfiguration>();

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string sqlQuery = "SELECT * FROM ALARMCONFIGURATION ORDER BY AlarmConfigurationId";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    AlarmConfiguration alarmConfiguration = new AlarmConfiguration();
                    alarmConfiguration.AlarmId = Convert.ToInt32(dr["AlarmId"]);
                    alarmConfiguration.AlarmConfigId = Convert.ToInt32(dr["AlarmConfigurationId"]);
                    alarmConfiguration.AlarmName = dr["Name"].ToString();
                    alarmConfiguration.AlarmDescription = dr["Description"].ToString();
                    alarmConfiguration.LowerLimit = Convert.ToInt32(dr["AlarmLowerLimit"]);
                    alarmConfiguration.UpperLimit = Convert.ToInt32(dr["AlarmUpperLimit"]);

                    alarmConfigList.Add(alarmConfiguration);
                }
                con.Close();
            }
            return alarmConfigList;
        }
    }
}
