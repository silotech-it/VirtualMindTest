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
    public class PesoController : ApiController
    {
        // GET: Dolar
        private List<Currency> peso = new List<Currency>();

        // GET: api/User
        public IQueryable<Currency> GetPeso()
        {
            CommonGetStrategy item = new CommonGetStrategy();
            try
            {
                item.Strategy = new Peso();
                peso.Add(new Currency(item.Fetch().Price2Buy, item.Fetch().Price2Sell, item.Fetch().LastUpdate));
                return peso.AsQueryable();
            }
            catch
            {
                return peso.AsQueryable();
            }
        }
    }
}
