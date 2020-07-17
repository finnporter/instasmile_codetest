using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CurrencyConverterCodeTest.Models
{
    public class CurrencyConverterModel
    {
        public double Amount { get; set; }
        public string FromCurrency { get; set; }
        public string ToCurrency { get; set; }
        public string Result { get; set; }
        public bool ShowResult { get; set; }
        public IEnumerable<SelectListItem> CurrencyOptions { get; set; }
    }
}