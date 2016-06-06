using Microsoft.AspNet.Mvc;
using System;
using System.Diagnostics;

namespace LazerektWeb.Controllers {
    [Route("lazerekt")]
    public class ValuesController : Controller {
        // GET: /lazerekt/
        [HttpGet]
        public string Get() {
            return Startup.dbConnection.Database.ToString();
        }

        // GET 
        [HttpGet("login/{value}")]
        public string Get(string value) {
            // login je u formi stringa login:hashed_pass
            var delimitiran = value.Split(new char[] { ':' });
            string login, hashed_pass;

            try {
                login = delimitiran[0];
                hashed_pass = delimitiran[1];
            } catch (IndexOutOfRangeException e) {
                Debug.WriteLine("OutOfRange: " + e.ToString());
                return "ErrL01";
            } catch (Exception e) {
                Debug.WriteLine("Greska: " + e.ToString());
                return "Err001";
            }

            return hashed_pass + " | " + login;
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
