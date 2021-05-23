using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sideP.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace sideP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration configuration;
        public HomeController(ILogger<HomeController> logger,IConfiguration config)
        {
            this.configuration = config;
            _logger = logger;
        }
        

        public IActionResult Index()
        {
            //string connectionstring = configuration.GetConnectionString("DefaultConnectionString");
            //SqlConnection connection = new SqlConnection(connectionstring);
            //connection.Open();
            //SqlCommand sql = new SqlCommand("select count(*) from account", connection);
            //var count = (int)sql.ExecuteScalar();
            //ViewData["TotalData"] = count;
            //connection.Close();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
