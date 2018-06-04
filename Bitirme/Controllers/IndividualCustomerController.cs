using Bitirme.DBModel.Context;
using Bitirme.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bitirme.Controllers
{
    public class IndividualCustomerController : Controller
    {
        ProjectContext context = new ProjectContext();
        // GET: IndividualCustomer
        public ActionResult EditCurrentCustomer()
        {
            if (Session["login"] == "false" || Session["username"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                CustomerModel model = new CustomerModel();
                model.Customers = context.Customers.ToList();

                return View(model);
            }
        }

        public ActionResult AddNewCustomer()
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

        public ActionResult Reporting()
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