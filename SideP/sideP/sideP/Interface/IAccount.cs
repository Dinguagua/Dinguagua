﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sideP.Interface
{
    public interface IAccount
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool AccountValidation(string email, string password);
    }
}
