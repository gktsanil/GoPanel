using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bitirme.DBModel.Entity
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }
        [Index(IsUnique = true), Required, MaxLength(100)]
        public string SenderID { get; set; }
        public string ReciveID { get; set; }
        public string MessageText { get; set; }
        public DateTime MessageDate { get; set; }
    }
}