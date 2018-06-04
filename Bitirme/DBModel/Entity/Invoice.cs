using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bitirme.DBModel.Entity
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        [Index(IsUnique = true), Required, MaxLength(100)]
        public string InvoiceNumber { get; set; }
        public string CustomerName { get; set; }
        public Decimal TotalCost { get; set; }
        public Decimal Cost { get; set; }
        public int TaxRate { get; set; }
        public string InvoiceFile { get; set; }
        public int InvoiceType { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceDescription { get; set; }

        public virtual Customer Customer { get; set; }
    }
}