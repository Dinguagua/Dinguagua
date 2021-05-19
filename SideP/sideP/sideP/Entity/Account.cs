using sideP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sideP.Entity
{
    public class Account : IAccount
    {
        public string Email { get; set; } = "asd123@gmail.com";
        public string Password { get; set; } = "asd123";
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Birth { get; set; }
        public bool AccountValidation(string email, string password)
        {
            return Email == email && Password == password;
        }
    }
}
