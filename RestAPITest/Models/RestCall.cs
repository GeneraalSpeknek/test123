using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPITest.Models
{
    public class RestCall
    {

        public class Rootobject
        {
            public Restresponse RestResponse { get; set; }
        }

        public class Restresponse
        {
            public string[] messages { get; set; }
            public Result[] result { get; set; }
        }

        public class Result
        {
            public string country { get; set; }
            public string name { get; set; }
            public string abbr { get; set; }
            public string area { get; set; }
            public string largest_city { get; set; }
            public string capital { get; set; }

        }

    }
}
