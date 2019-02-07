using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using VirtMVC.Models;

namespace VirtMVC.Controllers
{
    public class PesoController: Controller
    {
        public ActionResult Index()
        {
            IEnumerable<mvcCurrency> pesoList;
            HttpResponseMessage response = GlobalVariables.webApiClient.GetAsync("Peso").Result;
            pesoList = response.Content.ReadAsAsync<IEnumerable<mvcCurrency>>().Result;
            if (pesoList.Count() > 0)
            {
                return View(pesoList);
            }
            else
            {
                return new HttpUnauthorizedResult("Access is Denied");
            }
        }

    }
}