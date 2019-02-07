using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using VirtMVC.Models;

namespace VirtMVC.Controllers
{
    public class RealController: Controller
    {
        public ActionResult Index()
        {
            IEnumerable<mvcCurrency> realList;
            HttpResponseMessage response = GlobalVariables.webApiClient.GetAsync("Real").Result;
            realList = response.Content.ReadAsAsync<IEnumerable<mvcCurrency>>().Result;
            if (realList.Count() > 0)
            {
                return View(realList);
            }
            else
            {
                return new HttpUnauthorizedResult("Access is Denied");
            }
        }

    }
}