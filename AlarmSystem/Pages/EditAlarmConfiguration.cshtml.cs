using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AlarmSystem.Model;
using Microsoft.Extensions.Configuration;

namespace AlarmSystem.Pages
{
    public class EditAlarmConfigurationModel : PageModel
    {
        readonly IConfiguration _configuration;
        public string connectionString;
        public AlarmConfiguration alarmDb = new AlarmConfiguration();
        public int alarmConfigurationId;

        public EditAlarmConfigurationModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
            alarmConfigurationId = Convert.ToInt32(Request.Query["alarmConfigurationId"]);
            AlarmConfiguration alarmConfiguration = new AlarmConfiguration();
            connectionString = _configuration.GetConnectionString("ConnectionString");
            alarmDb = alarmConfiguration.GetAlarmConfiguration(connectionString, alarmConfigurationId);
        }

        public void OnPost()
        {
            AlarmConfiguration alarmConfiguration = new AlarmConfiguration();
            alarmConfiguration.AlarmConfigId = Convert.ToInt32(Request.Form["alarmConfigurationId"]);
            alarmConfiguration.AlarmName = Request.Form["alarmName"];
            alarmConfiguration.AlarmDescription = Request.Form["alarmDescription"];
            alarmConfiguration.AlarmLevel = Request.Form["alarmLevel"];
            alarmConfiguration.TagName = Request.Form["tagName"];
            alarmConfiguration.LowerLimit = Convert.ToInt32(Request.Form["lowerLimit"]);
            alarmConfiguration.UpperLimit = Convert.ToInt32(Request.Form["upperLimit"]);
            connectionString = _configuration.GetConnectionString("ConnectionString");
            alarmConfiguration.EditAlarmConfiguration(connectionString, alarmConfiguration);
            Response.Redirect("./AlarmConfiguration");

        }
    }
}
