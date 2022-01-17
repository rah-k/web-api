using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShoppingMVC.Models;
using ShoppingMVC.respos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingMVC.Controllers
{
    public class HomeController : Controller
    {
        
        

        public ViewResult Index()
        {
            return View();
        }
       

        public ViewResult Mens()
        {
            return View();
        }

       
    }
}
