using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01603404SuyeonJang.Controllers
{
    public class HostingCostController : ApiController
    {
        public string Get(int id) {
            int fn_number = (id / 14) + 1;
            double fn_price = fn_number * 5.50;
            double fn_hst = Math.Truncate(fn_price * 13)/100;
            double fn_total = Math.Truncate(fn_price *113)/100;
            string FN = fn_number + " fortnights at $5.50/FN = $" + fn_number * 5.50 + " CAD";
            string HST = "HST 13% = $"+ fn_hst + " CAD";
            string Total = "Total = $"+ fn_total + " CAD";

            return FN + HST + Total;
        }
    }
}
