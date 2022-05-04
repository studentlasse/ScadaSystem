using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public void OnGet(int p = 1)
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

    }
}
