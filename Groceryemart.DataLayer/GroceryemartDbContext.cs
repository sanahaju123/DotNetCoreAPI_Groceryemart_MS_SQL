using GroceryEmart.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryEmart.DataLayer
{
    public class GroceryemartDbContext :DbContext
    {
        public GroceryemartDbContext(DbContextOptions<GroceryemartDbContext> options) : base(options)
        {

        }
        /// <summary>
        /// Seed and create DbSet for all loan class
        /// </summary>
        public DbSet<ApplicationUser> users { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductOrder> productOrders { get; set; }
        
    }
}
