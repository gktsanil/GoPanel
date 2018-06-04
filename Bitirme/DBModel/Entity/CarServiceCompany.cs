using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bitirme.DBModel.Entity
{
    public class CarServiceCompany
    {
        [Key]
        public int ServiceID { get; set; }
        [Index(IsUnique = true), Required, MaxLength(100)]
        public string ServiceName { get; set; }
        public string ServiceAddress { get; set; }
        public int ServicePhone { get; set; }
        public string VergiDairesi { get; set; }
    }
}