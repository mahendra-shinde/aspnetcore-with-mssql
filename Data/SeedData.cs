using DotNETCoreGettingStarted.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNETCoreGettingStarted.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ShopDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ShopDbContext>>()))
            {
                if (context.Products.Any())
                    {
                        return;   
                    }
                if (context.Categories.Any())
                {
                    return;
                }
                var categories = new List<Category>{
                    new Category{ Name="Mobiles" , Description="All brand mobiles" },
                    new Category{ Name="Televisions", Description="Television products"}
                };
                context.Categories.AddRange(
                    categories.ToArray()
                );
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Samsung Galaxy S9",
                        Price = 69450,
                        Quantity = 30,
                        MfgDate = new DateTime(2018, 05, 10),
                        Category=categories.ToArray()[0]
                    },
                    new Product
                    {
                        Name = "Philips X40 LED TV",
                        Price = 32000,
                        Quantity = 10,
                        MfgDate = new DateTime(2015, 09, 10),
                        Category=categories.ToArray()[1]
                    },
                    new Product
                    {
                        Name = "LG C3200 Curve LED TV",
                        Price = 46000,
                        Quantity = 15,
                        MfgDate = new DateTime(2017, 07, 22),
                        Category=categories.ToArray()[1]
                    },
                    new Product
                    {
                        Name = "Apple X",
                        Price = 75000,
                        Quantity = 10,
                        MfgDate = new DateTime(2017, 11, 21),
                        Category=categories.ToArray()[0]
                    }
                );
                context.SaveChanges();
            }
        }
    }
}