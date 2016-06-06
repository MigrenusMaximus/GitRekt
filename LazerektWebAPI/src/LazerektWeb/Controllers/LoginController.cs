using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Text;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LazerektWeb.Controllers
{
    [Route("lazerekt/login")]
    public class LoginController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Get out of here" };
        }

        // GET api/values/5
        [HttpGet("{value}")]
        public string Get(string value)
        {
            // login je u formi stringa login:hashed_pass
            var delimitiran = value.Split(new char[] { ':' });
            string login, pass;

            try {
                login = delimitiran[0];
                pass = delimitiran[1];
            }
            catch (IndexOutOfRangeException e) {
                Debug.WriteLine("OutOfRange: " + e.ToString());
                return "ErrL01";
            }
            catch (Exception e) {
                Debug.WriteLine("Greska: " + e.ToString());
                return "Err001";
            }

            byte[] digest = Startup.hashManager.ComputeHash(Encoding.UTF8.GetBytes(login + pass));
            var hashed_pass = Convert.ToBase64String(digest);

            string loginQuery = "SELECT Id FROM dbo.Users WHERE Username='" + login + "' AND Password_Hash='" + hashed_pass + "';";
            var command = new SqlCommand(loginQuery, Startup.dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            if (!reader.Read()) {
                reader.Close();
                return "invalid";
            }

            string uId = reader[0].ToString();
            reader.Close();

            return uId;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
