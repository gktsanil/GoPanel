using Bitirme.DBModel.Context;
using Bitirme.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bitirme.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (Session["login"] == "false" || Session["username"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                ProjectContext context = new ProjectContext();

                DashboardModel model = new DashboardModel();
                model.Cars = context.Cars.ToList();

                return View(model);
            }            
        }
    }
}