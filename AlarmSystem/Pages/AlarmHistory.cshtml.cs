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

        public AlarmHistoryModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            connectionString = _configuration.GetConnectionString("ConnectionString");
            Alarm alarm = new Alarm();
            alarmHistoryList = alarm.GetAlarmHistoryList(connectionString);
        }
    }
}
