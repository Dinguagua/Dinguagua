using Microsoft.AspNetCore.Mvc;
using sideP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sideP.Entity;

namespace sideP.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccount _account;

        public AccountController(IAccount account)
        {
            _account = account;
        }
        public bool Login(string email, string password)
        {
            return _account.AccountValidation(email, password);
        }

        public IActionResult Register(Account userinfo)
        {
            
            return Ok() ;
        }
    }
}
