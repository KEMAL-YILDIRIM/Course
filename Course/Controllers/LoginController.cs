using Course.Data;
using Course.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course.Controllers
{
    public class LoginController : Controller
    {
        Model db = new Model();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {

            var kayit = db.Admin.Find(model.Email);


            if (ModelState.IsValid)
            {

                if (kayit != null && kayit.Sifre == model.Password)
                {
                    Session.Add("role", "Admin");
                    return RedirectToAction("Index", "Admin");
                }

                return RedirectToAction("Index", "User");
            }
            else
            {
                return View();
            }
        }
    }
}