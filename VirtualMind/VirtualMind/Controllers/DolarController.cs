using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using VirtMVC.Strategy.Models;
using VirtualMind.Strategy.Classes;

namespace VirtualMind.Controllers
{
    public class DolarController : ApiController
    {
        // GET: Dolar
        private List<Currency> dolar = new List<Currency>();

        // GET: api/User
        public IQueryable<Currency> GetDolar()
        {
            CommonGetStrategy item = new CommonGetStrategy();
            try
            {
                item.Strategy = new Dolar();
                dolar.Add(new Currency(item.Fetch().Price2Buy, item.Fetch().Price2Sell, item.Fetch().LastUpdate));
                return dolar.AsQueryable();
            }
            catch
            {
                return dolar.AsQueryable();
            }
        }
    }
}
