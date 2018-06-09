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
    public class BookingController : Controller
    {
        ProjectContext context = new ProjectContext();
        // GET: Booking
        public ActionResult BookingEdit()
        {
            if (Session["login"] == "false" || Session["username"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                BookingModel model = new BookingModel();
                model.Cars = context.Cars.ToList();
                model.Reservations = context.Reservations.ToList();
                model.Customers = context.Customers.ToList();

                return View(model);
            }
        }

        // GET: Booking
        public ActionResult AddBooking()
        {
            if (Session["login"] == "false" || Session["username"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                BookingModel model = new BookingModel();
                model.Cars = context.Cars.ToList();
                model.Reservations = context.Reservations.ToList();
                model.Customers = context.Customers.ToList();

                return View(model);
            }
        }

        [HttpPost]
        public ActionResult AddBooking(string customerName,string carPlate,DateTime startDate,DateTime endDate,string description, string sellerName)
        {
            if (Session["login"] == "false" || Session["username"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                BookingModel model = new BookingModel();
                model.Cars = context.Cars.ToList();
                model.Reservations = context.Reservations.ToList();
                model.Customers = context.Customers.ToList();

                Reservation rez = new Reservation
                {
                    CarPlateNumber = carPlate,
                    CustomerName = customerName,
                    StartDate = startDate,
                    EndDate = endDate,
                    ReservationDescription = description,
                    SellerName = sellerName
                };

                try
                {
                    context.Reservations.Add(rez);
                    context.SaveChanges();
                }
                catch(Exception e)
                {
                    ViewBag.error = "Rezervasyon Oluşturulamadı";
                    ViewBag.tagClass = "active";
                    Console.Write(e.Message);
                }

                return View(model);
            }
        }

        // GET: Booking
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