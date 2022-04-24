using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AlarmSystem.Model;
using Microsoft.Extensions.Configuration;

namespace AlarmSystem.Pages
{
    public class AlarmConfigurationModel : PageModel
    {
        readonly IConfiguration _configuration;
        public string connectionString;

        //public AlarmConfiguration alarmConfigurationData = new AlarmConfiguration();
        public List<AlarmConfiguration> alarmConfigurations = new List<AlarmConfiguration>();

        public AlarmConfigurationModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            alarmConfigurations = GetAlarmConfigurationList();
        }

        private List<AlarmConfiguration> GetAlarmConfigurationList()
        {
            connectionString = _configuration.GetConnectionString("ConnectionString");

            List<AlarmConfiguration> alarmConfigurationList = new List<AlarmConfiguration>();
            AlarmConfiguration alarmConfiguration = new AlarmConfiguration();
            alarmConfigurationList = alarmConfiguration.GetAlarmConfigList(connectionString);

            return alarmConfigurationList;
        }
    }
}
