using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() {
            //Dictionary<string, Product> product = new Dictionary<string, Product> {
            //    ["Kayak"]= new Product { Name = "Kayak", Price = 275M },
            //    ["LifeJacket"] = new Product { Name = "Lifejacket", Price = 48.95M } };
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProduct() };

            
            decimal priceFilterTotal = cart.FilterByPrice(20).TotalPrices();
            decimal nameFilterTotal = cart.FilterByName("S").TotalPrices();
            
            return View("Index", new string[] { $"Price Total: {priceFilterTotal:C2}",
            $"Name Total: {nameFilterTotal:C2}"});
        }
    }
}
