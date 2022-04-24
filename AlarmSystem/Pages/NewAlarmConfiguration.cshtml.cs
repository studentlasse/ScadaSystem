using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AlarmSystem.Model;
using Microsoft.Extensions.Configuration;

namespace AlarmSystem.Pages
{
    public class NewAlarmConfigurationModel : PageModel
    {
        readonly IConfiguration _configuration;
        public string connectionString;

        public NewAlarmConfigurationModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {

        }

        public void OnPost()
        {
            AlarmConfiguration alarmConfiguration = new AlarmConfiguration();
            alarmConfiguration.AlarmName = Request.Form["alarmName"];
            alarmConfiguration.AlarmDescription = Request.Form["alarmDescription"];
            alarmConfiguration.AlarmLevel = Request.Form["alarmLevel"];
            alarmConfiguration.TagName = Request.Form["tagName"];
            try
            {
                alarmConfiguration.LowerLimit = Convert.ToInt32(Request.Form["lowerLimit"]);
                alarmConfiguration.UpperLimit = Convert.ToInt32(Request.Form["upperLimit"]);
            }
            catch (Exception ex)
            {
                
            }
            connectionString = _configuration.GetConnectionString("ConnectionString");
            alarmConfiguration.CreateAlarmConfiguration(connectionString, alarmConfiguration);
            Response.Redirect("./AlarmConfiguration");
        }
    }
}
