using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CaracasFruitContext: DbContext
    {
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Fruit> Fruits { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }
    }
}
