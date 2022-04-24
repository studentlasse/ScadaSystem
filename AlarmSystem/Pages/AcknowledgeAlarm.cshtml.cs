using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AlarmSystem.Model;
using Microsoft.Extensions.Configuration;

namespace AlarmSystem.Pages
{
    public class AcknowledgeAlarmModel : PageModel
    {
        readonly IConfiguration _configuration;
        public string connectionString;
        public int alarmId;

        public AcknowledgeAlarmModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            alarmId = Convert.ToInt32(Request.Query["alarmid"]);
            connectionString = _configuration.GetConnectionString("ConnectionString");
            Alarm alarm = new Alarm();
            alarm.AcknowledgeAlarm(connectionString, alarmId);
            Response.Redirect("./Alarms");
        }
    }
}
