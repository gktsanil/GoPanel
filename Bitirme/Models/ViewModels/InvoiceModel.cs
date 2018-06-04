using Bitirme.DBModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bitirme.Models.ViewModels
{
    public class InvoiceModel
    {
        public List<Invoice> Invoices { get; set; }
        public List<Customer> Customers { get; set; }
    }
}