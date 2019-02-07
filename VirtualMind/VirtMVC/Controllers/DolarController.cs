using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using VirtMVC.Models;

namespace VirtMVC.Controllers
{
    public class DolarController : Controller
    {
        // GET: Dolar
        public ActionResult Index()
        {
            IEnumerable<mvcCurrency> dolarList;
            HttpResponseMessage response = GlobalVariables.webApiClient.GetAsync("Dolar").Result;
            dolarList = response.Content.ReadAsAsync<IEnumerable<mvcCurrency>>().Result;
            if (dolarList.Count() > 0)
            {
                return View(dolarList);
            }
            else
            {
                return new HttpUnauthorizedResult("Access is Denied");
            }
        }
    }
}