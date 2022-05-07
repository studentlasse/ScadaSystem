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
        public Person person = new Person();

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            GetCurrentUser();
        }

        public void OnPost()
        {
            AddNewUser();
        }

        public void OnPostLogin()
        {
            LogIn();
        }

        public void AddNewUser()
        {
            person.Name = Request.Form["personName"];
            person.Title = Request.Form["personTitle"];
            person.Username = Request.Form["personUsername"];
            person.Password = Request.Form["personPassword"];

            connectionString = _configuration.GetConnectionString("ConnectionString");
            person.CreateNewPerson(connectionString, person);
            //Response.Redirect("./Index");
        }

        public void LogIn()
        {
            person.Username = Request.Form["personUsername"];
            person.Password = Request.Form["personPassword"];

            connectionString = _configuration.GetConnectionString("ConnectionString");
            person.GetPersonInfo(connectionString, person.Username);
            //Response.Redirect("./Alarms");
        }

        public void GetCurrentUser()
        {
            connectionString = _configuration.GetConnectionString("ConnectionString");
            person.GetPersonInfo(connectionString, person.Username);
        }

    }
}
