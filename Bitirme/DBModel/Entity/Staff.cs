using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bitirme.DBModel.Entity
{
    public class Staff
    {
        [Key]
        public int StaffID { get; set; }
        public string StaffName { get; set; }
        public string StaffIdentityNumber { get; set; }
        public string StaffPhone { get; set; }
        public string StaffAddress { get; set; }
        public string StaffPosition { get; set; }
        public DateTime StaffStartdate { get; set; }
        public Decimal StaffSalery { get; set; }
        public string Notes { get; set; }
        public string Documents { get; set; }
    }
}