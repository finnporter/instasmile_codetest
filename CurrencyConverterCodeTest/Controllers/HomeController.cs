using CurrencyConverterCodeTest.Helpers;
using CurrencyConverterCodeTest.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CurrencyConverterCodeTest.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var model = new CurrencyConverterModel()
            {
                CurrencyOptions = DropdownHelper.GetCurrencies(),
                ShowResult = false
            };
            return View(model);
        }
        
        [HttpPost]
        public ActionResult Index(CurrencyConverterModel model)
        {
            if (ModelState.IsValid)
            {
                var resultModel = new CurrencyConverterModel()
                {
                    Amount = model.Amount,
                    CurrencyOptions = DropdownHelper.GetCurrencies(),
                    FromCurrency = model.FromCurrency,
                    ToCurrency = model.ToCurrency, 
                    ShowResult = true,                    
                    Result = ExchangeRateHelper.GetExchangedValue(model.Amount, model.FromCurrency, model.ToCurrency).ToString()
                };
                return View(resultModel);
            }
            return RedirectToAction("Index");
        }
    }
}