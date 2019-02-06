using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using VirtMVC.Models;

namespace VirtMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            IEnumerable<mvcUserModel> userList;
            HttpResponseMessage response = GlobalVariables.webApiClient.GetAsync("User").Result;
            userList = response.Content.ReadAsAsync<IEnumerable<mvcUserModel>>().Result;

            return View(userList);
        }
    }
}