using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace CurrencyConverterCodeTest.Helpers
{
    public static class JsonHelper
    {
        public static dynamic ReadJson()
        {
            //TODO store url in a central place, eg. config file, with other global variables
            string url = "https://api.exchangerate-api.com/v4/latest/USD";
            string json = new WebClient().DownloadString(url);

            var jss = new JavaScriptSerializer();
            return jss.Deserialize<Dictionary<string, dynamic>>(json);
        }
    }
}