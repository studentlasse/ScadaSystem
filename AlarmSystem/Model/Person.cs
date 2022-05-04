using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace AlarmSystem.Model
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Person GetPersonInfo(string connectionString, int personId)
        {
            Person person = new Person();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string sqlQuery = "SELECT * FROM GetPerson WHERE PersonId=@personid";


            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            var personIdParameter = new SqlParameter("personid", System.Data.SqlDbType.Int);
            personIdParameter.Value = personId;
            cmd.Parameters.Add(personIdParameter);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    person.PersonId = Convert.ToInt32(dr["PersonId"]);
                    person.Name = dr["PersonName"].ToString();
                    person.Title = dr["PersonTitle"].ToString();
                    person.Username = dr["PersonUsername"].ToString();
                    person.Password = dr["PersonPassword"].ToString();
                }

            }
            con.Close();
            return person;
        }

        public List<Person> GetPersonList(string connectionString)
        {
            List<Person> personList = new List<Person>();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string sqlQuery = "SELECT * FROM GetPerson";


            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    Person person = new Person();
                    person.PersonId = Convert.ToInt32(dr["PersonId"]);
                    person.Name = dr["PersonName"].ToString();
                    person.Title = dr["PersonTitle"].ToString();
                    person.Username = dr["PersonUsername"].ToString();
                    person.Password = dr["PersonPassword"].ToString();

                    personList.Add(person);
                }

            }
            con.Close();
            return personList;
        }

        public void CreateNewPerson(string connectionString, Person person)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("CreatePerson", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    // LAG STORED PROCEDURES I SQL
                    // Legg til "logged in as ... user" på hver side
                    // Fiks Acknowledge alarm proceduren til å hente person navn basert på innlogget ID
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
