﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01603404SuyeonJang.Controllers
{
    public class AddTenController : ApiController
    {
        public int Get(int id) {
            int addTen = id + 10;
            return addTen;
        }
    }
}
