using Bitirme.DBModel.Context;
using Bitirme.DBModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bitirme.Controllers
{
    public class NewAdminController : Controller
    {
        // GET: NewAdmin
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name, string position, string eposta, string phone)
        {
            var context = new ProjectContext();

            ConfirmationAdmin newUser = new ConfirmationAdmin();// make object of table
            newUser.Name = name;
            newUser.Position = position;
            newUser.Email = eposta;
            newUser.UserNumber = phone;
            //add if any field you want insert

            try
            {
                context.ConfirmationAdmins.Add(newUser);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                ViewBag.error = "Başvurunuz Gönderilemedi";
                ViewBag.tagClass = "active";
                Console.Write(e.Message);
            }

            return View();
        }
    }
}