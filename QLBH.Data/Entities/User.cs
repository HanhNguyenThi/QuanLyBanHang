using System;
using System.Collections.Generic;
using System.Text;

namespace QLBH.Data.Entities
{
   public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string FullName { get; set; }
        public DateTime LastLoginDate { get; set; }
   }
}
