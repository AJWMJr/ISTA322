﻿using Microsoft.AspNetCore.Mvc;
using MVC_Lab04.Models;
using System;

namespace MVC_Lab04.Controllers
{
    public class HomeController : Controller
    {
        bool FilterByPrice(Product p) { return (p?.Price ?? 0) >= 20; }
        public ViewResult Index() {
            Product[] productArray =
             {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            decimal priceFilterTotal = productArray.Filter(p => (p?.Price ?? 0) >= 20).TotalPrices();
            decimal nameFilterTotal = productArray.Filter(p => p?.Name?[0] == 'S').TotalPrices();

            return View(new string[] { 
                $"Price Total: {priceFilterTotal:C2}",
                $"Name Total: {nameFilterTotal:C2}"
            });
        }

    }
}
