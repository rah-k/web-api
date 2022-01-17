using Microsoft.AspNetCore.Mvc;
using ShoppingMVC.Models;
using ShoppingMVC.respos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly productrepos _productrepo = null;
        public ProductController()
        {
            _productrepo = new productrepos();
        }

        public ViewResult GetProduct()
        {
            var data = _productrepo.GetProduct();
            return View(data);
        }
        public ViewResult GetwomensProduct()
        {
            var data = _productrepo.GetProductWomens();
            return View(data);
        }
        public ViewResult GetProductId(int id)
        {
            var data= _productrepo.GetProductId(id);
            return View(data);
        }
    }
}
