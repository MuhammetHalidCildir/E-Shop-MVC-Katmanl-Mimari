using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class DataContext:DbContext
    {

        public readonly static string conn_str = (@"Server = DESKTOP-EO459P4; initial catalog=E-Shop; User Id = ; Password=");

      
        public DataContext() : base(conn_str)
        {
        }

        // Server=DESKTOP-EO459P4;Database=EShop;User Id = sa; Password=1;



        public DbSet<Cart> Carts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Sales> Saless { get; set; }
        public DbSet<User> Users { get; set; }
    }
    
}
