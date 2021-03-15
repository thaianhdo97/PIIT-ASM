using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoThaiAnh_PIIT_ASM.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public AccountStatus Status { get; set; }
    }

    public enum AccountStatus
    {
        ACTIVE, PENDING, DEACTIVE
    }
}