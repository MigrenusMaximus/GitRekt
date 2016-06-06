using Microsoft.AspNet.Mvc;
using System;
using System.Diagnostics;

namespace LazerektWeb.Controllers {
    [Route("lazerekt")]
    public class MainController : Controller {
        // GET: /lazerekt/
        [HttpGet]
        public string Get() {
            return "what are you doing here?";
        }

        // GET 
        [HttpGet("{value}")]
        public string Get(string value) {
            return "nil";
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
