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
    public class RealController : ApiController
    {
        // GET: Dolar
        private List<Currency> real = new List<Currency>();

        // GET: api/User
        public IQueryable<Currency> GetReal()
        {
            CommonGetStrategy item = new CommonGetStrategy();
            try
            {
                item.Strategy = new Real();
                real.Add(new Currency(item.Fetch().Price2Buy, item.Fetch().Price2Sell, item.Fetch().LastUpdate));
                return real.AsQueryable();
            }
            catch
            {
                return real.AsQueryable();
            }
        }
    }
}
