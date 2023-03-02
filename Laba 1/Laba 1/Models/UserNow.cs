using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1.Models
{
    public static class UserNow
    {
        public static string Login { get; set; }
        public static string Phone { get; set; }
        public static string Email { get; set; }
        public static string Password { get; set; }
        public static string Address { get; set; }
        public static string Role { get; set; }
        public static DateTime Birthday { get; set; }
        public static string getBirthday { get { return Birthday.ToString(); }}


    }
}
