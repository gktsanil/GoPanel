using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bitirme.DBModel.Entity
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }
        public string CarID { get; set; }
        public string CustomerName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ReservationDescription { get; set; }
        public string SellerName { get; set; }
        public string CarPlateNumber { get; set; }
    }
}