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
    public class UserController : Controller
    {
        ProjectContext contexts = new ProjectContext();
        // GET: User
        public ActionResult AddNewUser()
        {
            if (Session["login"] == "false" || Session["username"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                return View();
            }
        }

        public ActionResult StandardUser()
        {
            if (Session["login"] == "false" || Session["username"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                return View();
            }
        }

        public ActionResult AdminUser()
        {
            if (Session["login"] == "false" || Session["username"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                UserModel model = new UserModel();
                model.Users = contexts.Users.ToList();
                return View(model);
            }
        }

        public ActionResult StaffUser()
        {
            if (Session["login"] == "false" || Session["username"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult AddNewUser(string username, string password, string name, string email, string phone)
        {
            var context = new ProjectContext();

            User newUser = new User();// make object of table
            newUser.UserName = name;
            newUser.UserEmail = email;
            newUser.UserNickName = username;
            newUser.UserPassword = password;
            newUser.UserNumber = phone;
            //add if any field you want insert
            context.Users.Add(newUser);
            context.SaveChanges();

            return View();
        }
    }
}