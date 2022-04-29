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
        public string AlarmLevel { get; set; }
        public string TagName { get; set; }


        public int AlarmId { get; set; }

        public AlarmConfiguration GetAlarmConfiguration(string connectionString, int alarmConfigId)
        {
            AlarmConfiguration alarmConfiguration = new AlarmConfiguration();

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string sqlQuery = "SELECT * FROM GetAlarmConfigurations WHERE AlarmConfigurationId=@alarmconfigid";


            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            var alarmConfigIdParameter = new SqlParameter("alarmconfigid", System.Data.SqlDbType.Int);
            alarmConfigIdParameter.Value = alarmConfigId;
            cmd.Parameters.Add(alarmConfigIdParameter);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    alarmConfiguration.AlarmConfigId = Convert.ToInt32(dr["AlarmConfigurationId"]);
                    alarmConfiguration.AlarmName = dr["AlarmName"].ToString();
                    alarmConfiguration.AlarmDescription = dr["AlarmDescription"].ToString();
                    alarmConfiguration.LowerLimit = Convert.ToInt32(dr["AlarmLowerLimit"]);
                    alarmConfiguration.UpperLimit = Convert.ToInt32(dr["AlarmUpperLimit"]);
                    alarmConfiguration.AlarmLevel = dr["AlarmLevel"].ToString();
                    alarmConfiguration.TagName = dr["TagName"].ToString();
                }

            }
            con.Close();
            return alarmConfiguration;
        }

        public List<AlarmConfiguration> GetAlarmConfigList(string connectionString)
        {
            List<AlarmConfiguration> alarmConfigList = new List<AlarmConfiguration>();

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string sqlQuery = "SELECT * FROM GetAlarmConfigurations order by AlarmName ASC";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    AlarmConfiguration alarmConfiguration = new AlarmConfiguration();
                    alarmConfiguration.AlarmConfigId = Convert.ToInt32(dr["AlarmConfigurationId"]);
                    alarmConfiguration.AlarmName = dr["AlarmName"].ToString();
                    alarmConfiguration.AlarmDescription = dr["AlarmDescription"].ToString();
                    alarmConfiguration.LowerLimit = Convert.ToInt32(dr["AlarmLowerLimit"]);
                    alarmConfiguration.UpperLimit = Convert.ToInt32(dr["AlarmUpperLimit"]);
                    alarmConfiguration.AlarmLevel = dr["AlarmLevel"].ToString();
                    alarmConfiguration.TagName = dr["TagName"].ToString();

                    alarmConfigList.Add(alarmConfiguration);
                }
                con.Close();
            }
            return alarmConfigList;
        }

        public void CreateAlarmConfiguration(string connectionString, AlarmConfiguration alarmConfiguration)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("CreateAlarmConfiguration", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@AlarmName", alarmConfiguration.AlarmName));
                    cmd.Parameters.Add(new SqlParameter("@AlarmDescription", alarmConfiguration.AlarmDescription));
                    cmd.Parameters.Add(new SqlParameter("@AlarmLevel", alarmConfiguration.AlarmLevel));
                    cmd.Parameters.Add(new SqlParameter("@TagName", alarmConfiguration.TagName));
                    cmd.Parameters.Add(new SqlParameter("@AlarmLowerLimit", alarmConfiguration.LowerLimit));
                    cmd.Parameters.Add(new SqlParameter("@AlarmUpperLimit", alarmConfiguration.UpperLimit));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditAlarmConfiguration(string connectionString, AlarmConfiguration alarmConfiguration)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateAlarmConfiguration", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@AlarmConfigurationId", alarmConfiguration.AlarmConfigId));
                    cmd.Parameters.Add(new SqlParameter("@AlarmName", alarmConfiguration.AlarmName));
                    cmd.Parameters.Add(new SqlParameter("@AlarmDescription", alarmConfiguration.AlarmDescription));
                    cmd.Parameters.Add(new SqlParameter("@AlarmLevel", alarmConfiguration.AlarmLevel));
                    cmd.Parameters.Add(new SqlParameter("@TagName", alarmConfiguration.TagName));
                    cmd.Parameters.Add(new SqlParameter("@AlarmLowerLimit", alarmConfiguration.LowerLimit));
                    cmd.Parameters.Add(new SqlParameter("@AlarmUpperLimit", alarmConfiguration.UpperLimit));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteAlarmConfiguration(string connectionString, AlarmConfiguration alarmConfiguration)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DeleteAlarmConfiguration", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@AlarmConfigurationId", alarmConfiguration.AlarmConfigId));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
