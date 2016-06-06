using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.Diagnostics;
using System.Text;
using System.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LazerektWeb.Controllers
{
    [Route("lazerekt/register")]
    public class RegisterController : Controller {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get() {
            return new string[] { "Get out of here" };
        }

        // GET api/values/5
        [HttpGet("{value}")]
        public string Get(string value) {
            // login je u formi stringa login:hashed_pass
            var delimitiran = value.Split(new char[] { ':' });
            string login, pass;

            try {
                login = delimitiran[0];
                pass = delimitiran[1];
            }
            catch (IndexOutOfRangeException e) {
                Debug.WriteLine("OutOfRange: " + e.ToString());
                return "ErrR01";
            }
            catch (Exception e) {
                Debug.WriteLine("Greska: " + e.ToString());
                return "Err001";
            }

            string checkUserQuery = "SELECT Id FROM dbo.Users WHERE Username='" + login + "';";
            var command = new SqlCommand(checkUserQuery, Startup.dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read()) {
                reader.Close();
                return "exists";
            }

            reader.Close();

            byte[] digest = Startup.hashManager.ComputeHash(Encoding.UTF8.GetBytes(login + pass));
            string hashed_pass = Convert.ToBase64String(digest);
            string addUserQuery = "INSERT INTO dbo.Users ([Username], [Password_Hash]) VALUES ('" + login + "', '" + hashed_pass + "');";
            command = new SqlCommand(addUserQuery, Startup.dbConnection);
            int status = command.ExecuteNonQuery();

            if (status < 1)
                return "failed";
            if (status > 1)
                return "catastrophic";

            return status.ToString();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value) {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value) {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
