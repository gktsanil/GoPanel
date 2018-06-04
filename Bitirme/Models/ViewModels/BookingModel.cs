using Bitirme.DBModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bitirme.Models.ViewModels
{
    public class BookingModel
    {
        public List<Reservation> Reservations { get; set; }
        public List<Car> Cars { get; set; }
        public List<Customer> Customers { get; set; }
    }
}