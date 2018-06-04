using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bitirme.DBModel.Entity
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
        public int PaidID { get; set; }
        public string PaidName { get; set; }
        public int PaidType { get; set; }
        public DateTime PaidDate { get; set; }
        public Decimal PaidCost { get; set; }
        public string SlipPath { get; set; }
        public string PaymentDescription { get; set; }

    }
}