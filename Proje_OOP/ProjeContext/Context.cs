﻿using Microsoft.EntityFrameworkCore;
using Proje_OOP.Entity;

namespace Proje_OOP.ProjeContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-83L42UFV\\SQLEXPRESS ; database=DbNewOopCore; integrated security= true; TrustServerCertificate=True");
        }

        public DbSet<Product>Products { get; set; }
        public DbSet<Customer> Customers { get; set; }  
        public DbSet<Category> Categories { get; set; }    

        
    }
}
