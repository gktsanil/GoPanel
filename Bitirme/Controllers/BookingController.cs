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

        public ActionResult EditReservation()
        {
            if (Session["login"] == "false" || Session["username"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                int id = int.Parse(this.RouteData.Values["id"].ToString());

                Reservation rez = null;

                if (id != null)
                {
                    rez = context.Reservations.Where(x => x.ReservationID == id).FirstOrDefault();
                    
                }

                return View(rez);
            }
        }
        [HttpPost]
        public ActionResult EditReservation(Reservation rez)
        {
            if (Session["login"] == "false" || Session["username"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                Reservation res = context.Reservations.Where(x => x.ReservationID == rez.ReservationID).FirstOrDefault();

                if (res != null)
                {
                    res.CustomerName = rez.CustomerName;
                    res.CarPlateNumber = rez.CarPlateNumber;
                    res.SellerName = rez.SellerName;
                    res.ReservationDescription = rez.ReservationDescription;

                    int sonuc = context.SaveChanges();

                    if (sonuc > 0)
                    {
                        ViewBag.Result = "Değişiklikler Kaydedilmiştir.";
                        ViewBag.Status = "success";
                    }
                    else
                    {
                        ViewBag.Result = "Değişiklikler Kaydedilmedi.";
                        ViewBag.Status = "danger";
                    }
                }

                return RedirectToAction("BookingEdit", "Booking");
            }
        }
    }
}