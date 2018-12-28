using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNETCoreGettingStarted.Models;
using DotNETCoreGettingStarted.Data;

namespace DotNETCoreGettingStarted.Controllers
{
    public class HomeController : Controller
    {
        private ShopDbContext _context;

        public HomeController(ShopDbContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {
            var catalog=_context.Products
                .Select(p=>new Catalog{
                    Id=p.Id,
                    Name=p.Name,
                    Quantity=p.Quantity,
                    Price=p.Price,
                    CategoryName=p.Category.Name,
                    MfgDate=p.MfgDate
                });
            return View(catalog);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Sample ASP.NET Application that consumes SQL Server database";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
