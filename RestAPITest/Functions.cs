using Newtonsoft.Json;
using RestAPITest.ConnectionModel;
using RestAPITest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestAPITest
{
    class Functions
    {
        public void jemoederlol()
        {
            IndianScumEntities indianscumentities = new IndianScumEntities();

            RestCall.Rootobject _jsonRootObject = JsonConvert.DeserializeObject<RestCall.Rootobject>(new WebClient().DownloadString("http://services.groupkt.com/state/get/IND/all"));

            foreach (var restResponse in _jsonRootObject.RestResponse.result)
            {
                indianlol kek = new indianlol();
                kek.abbr = restResponse.abbr;
                kek.area = restResponse.area;
                kek.capital = restResponse.capital;
                kek.country = restResponse.country;
                kek.largestcity = restResponse.largest_city;
                indianscumentities.indianlol.Add(kek);

                Console.WriteLine(kek.abbr + " " + kek.area + " " + kek.capital + " " + kek.country + " " + kek.largestcity); 
            }

            indianscumentities.SaveChanges();
        }
    }
}
