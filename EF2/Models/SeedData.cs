using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Builder.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF2.Models
{
    public static class SeedData
    {

        public static void Seed(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();


            context.Database.Migrate();


            if (!context.Products.Any())
            {
                context.AddRange(

                    new Product() { Name = "Product 1", Description = "Goood", Price = 200, Category = "Telefon" },
                    new Product() { Name = "Product 1", Description = "Goood", Price = 200, Category = "Telefon" },
                    new Product() { Name = "Product 1", Description = "Goood", Price = 200, Category = "Telefon" },
                    new Product() { Name = "Product 1", Description = "Goood", Price = 200, Category = "Telefon" },
                    new Product() { Name = "Product 1", Description = "Goood", Price = 200, Category = "Telefon" }
                    );
                context.SaveChanges();
            }
        }
    }
}
