using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clipcart.Controllers
{
    public class ClipcartController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
