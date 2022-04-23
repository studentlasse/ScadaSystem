using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace AlarmSystem.Models
{
    public class Alarm
    {
        public int AlarmId { get; set; }  
        public string TimeStamp { get; set; }
        public int AlarmConfigId { get; set; }
        public int AcknowledgeId { get; set; }
        public double Value { get; set; }

        public Alarm GetAlarm(string connectionString, int alarmId)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string sqlQuery = "SELECT AlarmId, AcknowledgeId, AlarmConfigurationId, FORMAT(TimeStamp,'MM.dd HH:mm:ss') AS TimeStamp, Value FROM ALARM WHERE AlarmId=@alarmid";


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
                alarm.TimeStamp = dr["TimeStamp"].ToString();
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

            string sqlQuery = "SELECT AlarmId, AcknowledgeId, AlarmConfigurationId, FORMAT(TimeStamp,'MM.dd HH:mm:ss') AS TimeStamp, Value FROM ALARM order by AlarmConfigurationId DESC";

            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            SqlDataReader dr = cmd.ExecuteReader();

            // TODO: LEGG TIL SLIK AT NÅR CONFIGURATION ID HENTES, VIS DESCRIPTION ETC ISTEDENFOR
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
                    alarm.AlarmConfigId = Convert.ToInt32(dr["AlarmConfigurationId"]);
                    alarm.AcknowledgeId = Convert.ToInt32(dr["AcknowledgeId"]);
                    alarm.TimeStamp = dr["TimeStamp"].ToString();
                    alarm.Value = Convert.ToDouble(dr["Value"]);

                    alarmList.Add(alarm);
                }
                con.Close();

            }
            return alarmList;
        }
    }
}
