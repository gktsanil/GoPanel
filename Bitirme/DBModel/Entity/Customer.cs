using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bitirme.DBModel.Entity
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerType { get; set; }

        public virtual List<Invoice> Invoices { get; set; }
        public virtual List<Reservation> Reservations { get; set; }

        public Customer()
        {
            this.Invoices = new List<Invoice>();
            this.Reservations = new List<Reservation>();
        }
    }
}