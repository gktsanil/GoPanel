using Bitirme.DBModel.Context;
using Bitirme.DBModel.Entity;
using Bitirme.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bitirme.Controllers
{
    public class LoginController : Controller
    {
        ProjectContext context = new ProjectContext();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(String username, String password)
        {
            UserModel model = new UserModel();
            model.Users = context.Users.ToList();

            foreach (var user in model.Users)
            {
                if (username == user.UserNickName)
                {
                    if (password == user.UserPassword)
                    {
                        Session["username"] = username;
                        Session["login"] = "true";
                        
                    }
                }
            }
            return RedirectToAction("Index", "Home");

        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login", "Login");
        }
    }
}