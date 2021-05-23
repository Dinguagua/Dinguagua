using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sideP.Interface
{
    public interface IAccount
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get;set; }
        public string Address { get; set; }
        public DateTime Birth { get; set; }
        public int Phone { get; set; }

        public bool AccountValidation(string email, string password);
    }
}
