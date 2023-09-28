using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01603404SuyeonJang.Controllers
{
    public class GreetingController : ApiController
    {
        [HttpPost]
        [Route("api/Greeting")]
        public string Greeting() {
            return "Hello World!";
        }
        [HttpGet]
        [Route("api/Greeting/{number}")]
        public string People(int number)
        {
            string people = "Greetings to " + number + " people!";
            return people;
        }
    }
}
