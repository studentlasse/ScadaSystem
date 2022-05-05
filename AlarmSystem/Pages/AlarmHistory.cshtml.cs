using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AlarmSystem.Model;
using Microsoft.Extensions.Configuration;

namespace AlarmSystem.Pages
{
    public class AlarmHistoryModel : PageModel
    {
        readonly IConfiguration _configuration;
        public string connectionString;

        public Alarm alarmHistoryData = new Alarm();
        public List<Alarm> alarmHistoryList = new List<Alarm>();
        public List<Alarm> alarms = new List<Alarm>();

        public AlarmHistoryModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            alarmHistoryList = GetHistoryAlarmList();
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

        private List<Alarm> GetHistoryAlarmList()
        {
            connectionString = _configuration.GetConnectionString("ConnectionString");

            List<Alarm> alarmList = new List<Alarm>();
            Alarm alarm = new Alarm();
            alarmList = alarm.GetAlarmHistoryList(connectionString);
            return alarmList;
        }
    }
}
