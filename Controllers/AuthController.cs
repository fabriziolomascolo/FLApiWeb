using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FLApiWeb.Models;

namespace FLApiWeb.Controllers
{
    [RoutePrefix("auth")]
    public class AuthController : ApiController
    {
        // GET api/auth
        [Route("")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/auth/5
        [Route("{id:int}")]
        public string Get(int id)
        {
            return "id";
        }
        // GET api/auth/fabrizio
        [HttpGet]
        [Route("id/{id:int}")]
        public string id(int id)
        {
            return "username";
        }
        // GET api/auth/fabrizio
        [HttpGet]
        [Route("username/{username}")]
        public string Username(String id)
        {
            return "username";
        }

        // POST api/<auth>
        [HttpPost]
        [Route("login")]
        public string login([FromBody] Login login)
        {
            BAL bal = new BAL();
            string response = bal.GetLogin(login);
            return response;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}