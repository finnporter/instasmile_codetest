using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Script.Serialization;

namespace CurrencyConverterCodeTest.Helpers
{
    public static class ExchangeRateHelper
    {
        public static double GetExchangedValue(double amount, string fromCurrency, string toCurrency)
        {
            var fromCurrencyToUsdRate = GetExchangeRateToBaseCurrency(fromCurrency);
            var toCurrencyToUsdRate = GetExchangeRateToBaseCurrency(toCurrency);

            return (fromCurrencyToUsdRate * amount) * toCurrencyToUsdRate;
        }

        private static double GetExchangeRateToBaseCurrency(string fromCurrency)
        {
            return double.Parse(JsonHelper.ReadJson()["rates"][fromCurrency].ToString());
        }
    }
}