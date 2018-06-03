using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bitirme.DBModel.Entity
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }
        [Index(IsUnique = true), Required, MaxLength(100)]
        public string CarPlateNumber { get; set; }
        public int CarYear { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string CarType { get; set; }
        public string CarGear { get; set; }
        public string CarImage { get; set; }
        public string CarFuel { get; set; }
    }
}