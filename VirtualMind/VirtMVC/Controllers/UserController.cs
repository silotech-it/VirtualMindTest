using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new mvcUserModel());
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.webApiClient.GetAsync("User/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<mvcUserModel>().Result);
            }
        }

        [HttpPost]
        public ActionResult AddOrEdit(mvcUserModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.id == 0 )
                {
                    HttpResponseMessage response = GlobalVariables.webApiClient.PostAsJsonAsync("User", model).Result;
                    TempData["SucessMessage"] = "Saved Successfully";
                }
                else
                {
                    HttpResponseMessage response = GlobalVariables.webApiClient.PutAsJsonAsync("User/" + model.id.ToString(), model).Result;
                    TempData["SucessMessage"] = "Updated Successfully";
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View("AddOrEdit", model);
            }            
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.webApiClient.DeleteAsync("User/" + id.ToString()).Result;
            TempData["SucessMessage"] = "Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}