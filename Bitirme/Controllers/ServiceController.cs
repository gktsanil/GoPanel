using Bitirme.DBModel.Context;
using Bitirme.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bitirme.Controllers
{
    public class ServiceController : Controller
    {
        ProjectContext context = new ProjectContext();

        // GET: Service
        public ActionResult OnService()
        {
            if (Session["login"] == "false" || Session["username"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {

                ServiceModel model = new ServiceModel();
                model.Cars = context.Cars.ToList();
                model.Services = context.Services.ToList();

                return View(model);
            }
        }

        public ActionResult ServiceTimeOut()
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

        public ActionResult GetReport()
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
    }
}