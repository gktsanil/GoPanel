using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bitirme.DBModel.Entity
{
    public class ConfirmationAdmin
    {
        [Key]
        public int ConfirmID { get; set; }
        public string Name { get; set; }
        [Index(IsUnique = true), Required, MaxLength(100), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string UserNumber { get; set; }
        public string Position { get; set; }
        public Boolean Confirm { get; set; }
    }
}