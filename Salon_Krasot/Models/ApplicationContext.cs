using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Krasot.Models
{
    internal class ApplicationContext :DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Product_Card> Products_Cards { get; set; }
        public DbSet<Product_Sale_History> Product_Sale_History { get; set;}
        public DbSet<User> Users { get; set; }
        public DbSet<ForLogin> ForLogin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Kalivan.db");
        }
    }
}
