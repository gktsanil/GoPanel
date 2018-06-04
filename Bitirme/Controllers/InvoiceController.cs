using Bitirme.DBModel.Context;
using Bitirme.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bitirme.Controllers
{

    public class InvoiceController : Controller
    {
        ProjectContext context = new ProjectContext();
        // GET: Invoice
        public ActionResult ComingInvoice()
        {
            if (Session["login"] == "false" || Session["username"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                InvoiceModel model = new InvoiceModel();
                model.Customers = context.Customers.ToList();
                model.Invoices = context.Invoices.ToList();
                return View(model);
            }
        }

        public ActionResult OutgoingInvoice()
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

        public ActionResult Printing()
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

        public ActionResult CreateInvoice()
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