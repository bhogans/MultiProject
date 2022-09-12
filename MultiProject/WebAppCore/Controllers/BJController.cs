using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanUp.Data.SqlServer;

namespace WebAppCore.Controllers
{
    public class BJController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
