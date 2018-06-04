using Bitirme.DBModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bitirme.Models.ViewModels
{
    public class ServiceModel
    {
        public List<Car> Cars { get; set; }
        public List<Service> Services { get; set; }
    }
}