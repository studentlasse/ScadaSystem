using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace AlarmSystem.Model
{
    public class Alarm
    {
        public int AlarmId { get; set; }  
        public string TimeStamp { get; set; }
        public int AlarmConfigId { get; set; }
        public int AcknowledgeId { get; set; }
        public double Value { get; set; }

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
                alarm.Value = Convert.ToDouble(dr["Value"]);
            }
            con.Close();
            return alarm;
        }

        public List<Alarm> GetAlarmList(string connectionString)
        {
            List<Alarm> alarmList = new List<Alarm>();

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string sqlQuery = "select * from GetAlarms";

            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            SqlDataReader dr = cmd.ExecuteReader();

            // TODO2: GJØR ALARMENE I TABELLEN "TRYKKBARE" FOR MER INFO
            // TODO3: LEGG TIL ACKNOWLEDGE KNAPP FOR HVER ALARM HVIS MULIG --> DENNE MÅ DA FORANDRE ACKNOWLEDGE VERDIEN TIL ALARMEN!
            // TODO4: NYE KLASSER: ALARMCONFIG, ALARMLEVEL, PERSON, ACKNOWLEDGMENT(?), TAGDATA(?)
            // TODO5: E-Post varsling evt. annen type varsling. 

            if (dr != null)
            {
                while (dr.Read())
                {
                    Alarm alarm = new Alarm();
                    alarm.AlarmId = Convert.ToInt32(dr["AlarmId"]);
                    alarm.TimeStamp = dr["AlarmTimeStamp"].ToString();
                    alarm.Value = Convert.ToDouble(dr["Value"]);
                    alarm.AlarmName = dr["AlarmName"].ToString();
                    alarm.AlarmDescription = dr["AlarmDescription"].ToString();
                    alarm.AlarmAcknowledged = Convert.ToBoolean(dr["AckStatus"]);

                    alarmList.Add(alarm);
                }
                con.Close();

            }
            return alarmList;
        }
        
        public void EditAlarm(string connectionString, Alarm alarm)
        {

        }
    }
}
