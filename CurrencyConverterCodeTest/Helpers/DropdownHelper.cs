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
    public static class DropdownHelper
    {
        public static IEnumerable<SelectListItem> GetCurrencies()
        {            
            var list = new List<SelectListItem>();
            var rates = JsonHelper.ReadJson()["rates"];
            foreach (var item in JsonHelper.ReadJson()["rates"])
            {
                list.Add(new SelectListItem() { Value = item.Key, Text = item.Key });               
            }
            return list.OrderBy(x => x.Text).ToList();
        }
    }
}