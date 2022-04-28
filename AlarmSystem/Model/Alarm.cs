using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace AlarmSystem.Model
{
    public class Alarm
    {
        public int AlarmId { get; set; }  
        public string TimeStamp { get; set; }
        public string AckTimeStamp { get; set; }
        public int AlarmConfigId { get; set; }
        public int AcknowledgeId { get; set; }
        public double Value { get; set; }
        public string AlarmLevel { get; set; }

        public string AlarmName { get; set; }
        public string AlarmDescription { get; set; }
        public bool AlarmAcknowledged { get; set; }

        public Alarm GetAlarm(string connectionString, int alarmId)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string sqlQuery = "SELECT AlarmId, AcknowledgeId, AlarmConfigurationId, FORMAT(AlarmTimeStamp,'MM.dd HH:mm:ss') AS AlarmTimeStamp, Value FROM ALARM WHERE AlarmId=@alarmid";


            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            var alarmIdParameter = new SqlParameter("alarmid", System.Data.SqlDbType.Int);
            alarmIdParameter.Value = alarmId;
            cmd.Parameters.Add(alarmIdParameter);

            SqlDataReader dr = cmd.ExecuteReader();

            Alarm alarm = new Alarm();

            if (dr.Read())
            {
                alarm.AlarmId = Convert.ToInt32(dr["AlarmId"]);
                alarm.AlarmConfigId = Convert.ToInt32(dr["AlarmConfigurationId"]);
                alarm.AcknowledgeId = Convert.ToInt32(dr["AcknowledgeId"]);
                alarm.TimeStamp = dr["AlarmTimeStamp"].ToString();
                alarm.Value = Math.Round(Convert.ToDouble(dr["Value"]), 2);
            }
            con.Close();
            return alarm;
        }

        public List<Alarm> GetAlarmList(string connectionString)
        {
            List<Alarm> alarmList = new List<Alarm>();

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string sqlQuery = "SELECT * from GetAlarms WHERE AckStatus=0 order by AlarmTimeStamp DESC";

            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    Alarm alarm = new Alarm();
                    alarm.AlarmId = Convert.ToInt32(dr["AlarmId"]);
                    alarm.TimeStamp = dr["AlarmTimeStamp"].ToString();
                    alarm.Value = Math.Round(Convert.ToDouble(dr["Value"]), 2);
                    alarm.AlarmName = dr["AlarmName"].ToString();
                    alarm.AlarmDescription = dr["AlarmDescription"].ToString();
                    alarm.AlarmAcknowledged = Convert.ToBoolean(dr["AckStatus"]);
                    alarm.AlarmLevel = dr["AlarmLevel"].ToString();

                    alarmList.Add(alarm);
                }
                con.Close();

            }
            return alarmList;
        }

        public List<Alarm> GetAlarmHistoryList(string connectionString)
        {
            List<Alarm> alarmList = new List<Alarm>();

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string sqlQuery = "SELECT * FROM GetAlarmHistory WHERE AckTimeStamp != 0 order by AckTimeStamp DESC";

            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    Alarm alarm = new Alarm();
                    alarm.AlarmId = Convert.ToInt32(dr["AlarmId"]);
                    alarm.TimeStamp = dr["AlarmTimeStamp"].ToString();
                    alarm.Value = Math.Round(Convert.ToDouble(dr["Value"]),2);
                    alarm.AlarmName = dr["AlarmName"].ToString();
                    alarm.AlarmDescription = dr["AlarmDescription"].ToString();
                    alarm.AckTimeStamp = dr["AckTimeStamp"].ToString();
                    alarm.AlarmLevel = dr["AlarmLevel"].ToString();

                    alarmList.Add(alarm);
                }
                con.Close();

            }
            return alarmList;
        }

        public void EditAlarm(string connectionString, Alarm alarm)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateAlarm", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@AlarmId", alarm.AlarmId));
                    cmd.Parameters.Add(new SqlParameter("@AlarmConfigurationId", alarm.AlarmConfigId));
                    cmd.Parameters.Add(new SqlParameter("@AcknowledgeId", alarm.AcknowledgeId));
                    cmd.Parameters.Add(new SqlParameter("@AlarmTimeStamp", alarm.TimeStamp));
                    cmd.Parameters.Add(new SqlParameter("@Value", alarm.Value));

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

        public void AcknowledgeAlarm(string connectionString, int alarmId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("AcknowledgeAlarm", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@AlarmId", alarmId));

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
