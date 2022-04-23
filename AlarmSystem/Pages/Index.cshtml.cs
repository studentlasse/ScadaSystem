using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AlarmSystem.Model;
using Microsoft.Extensions.Configuration;


namespace AlarmSystem.Pages
{
    public class IndexModel : PageModel
    {
        readonly IConfiguration _configuration;
        public string connectionString;

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            connectionString = _configuration.GetConnectionString("ConnectionString");

        }
    }
}
