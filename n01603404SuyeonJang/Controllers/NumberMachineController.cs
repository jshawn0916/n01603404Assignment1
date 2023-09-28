using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01603404SuyeonJang.Controllers
{
    public class NumberMachineController : ApiController
    {
        public int Get(int id) {
            int result = (id * 5) / 2;
            return result;
        }
    }
}
