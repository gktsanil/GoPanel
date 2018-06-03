using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bitirme.DBModel.Entity
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        [Index(IsUnique = true), Required, MaxLength(100), DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; }
        public string UserNumber { get; set; }
        public string UserNickName { get; set; }
        public string UserPassword { get; set; }
        public int UserType { get; set; }
        public string UserDescription { get; set; }
        public string UserProfileImage { get; set; }
        public string UserIdentityCard { get; set; }
    }
}