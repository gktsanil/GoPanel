using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bitirme.DBModel.Entity
{
    public class Service
    {
        [Key]
        public int ServiceID { get; set; }
        [Index(IsUnique = true), Required, MaxLength(100)]
        public string ServiceName { get; set; }
        public string CarPlateNumber { get; set; }
        public int ServicePhone { get; set; }
        public string ServiceFormPath { get; set; }
        public DateTime ServiceDate { get; set; }
        public string ServiceNote { get; set; }
        public string ServiceDescription { get; set; }

        public virtual List<Car> Cars { get; set; }

        public Service()
        {
            this.Cars = new List<Car>();
        }
    }
}