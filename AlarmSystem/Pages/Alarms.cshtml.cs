using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AlarmSystem.Model;
using Microsoft.Extensions.Configuration;


namespace AlarmSystem.Pages
{
    public class AlarmsModel : PageModel
    {
        readonly IConfiguration _configuration;
        public string connectionString;

        public List<Alarm> alarms = new List<Alarm>();


        public AlarmsModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            alarms = GetAlarmList();
        }

        private List<Alarm> GetAlarmList()
        {
            connectionString = _configuration.GetConnectionString("ConnectionString");

            List<Alarm> alarmList = new List<Alarm>();
            Alarm alarm = new Alarm();
            alarmList = alarm.GetAlarmList(connectionString);
            return alarmList;
        }

        /*public void OnPost()
        {
            Alarm alarm = new Alarm();
            alarm.AlarmId = Convert.ToInt32(Request.Query["AlarmId"]);
            connectionString = _configuration.GetConnectionString("ConnectionString");
            alarm.EditAlarm(connectionString, alarm);
            Response.Redirect("./Alarms");
        }*/
    }
}
