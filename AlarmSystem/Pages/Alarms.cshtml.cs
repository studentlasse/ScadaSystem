using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AlarmSystem.Models;
using Microsoft.Extensions.Configuration;


namespace AlarmSystem.Pages
{
    public class AlarmsModel : PageModel
    {
        readonly IConfiguration _configuration;
        public string connectionString;

        public Alarm alarmData = new Alarm();
        public List<Alarm> alarmList = new List<Alarm>();


        public AlarmsModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            connectionString = _configuration.GetConnectionString("ConnectionString");

            int alarmId = Convert.ToInt32(Request.Query["AlarmId"]);

            Alarm alarm = new Alarm();
            alarmList = alarm.GetAlarmList(connectionString);
        }
    }
}
