﻿using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext (DbContextOptions<ProductsContext> options)
            : base(options)
        {
            //Database.Migrate();
        }

        public DbSet<Product> Product { get; set; }
    }
}
