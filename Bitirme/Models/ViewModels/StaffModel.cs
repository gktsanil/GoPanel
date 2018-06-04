using Bitirme.DBModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bitirme.Models.ViewModels
{
    public class StaffModel
    {
        public List<Staff> Staffs { get; set; }
        public List<Payment> Payments { get; set; }
    }
}