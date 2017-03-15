using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SaleItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        [NotMapped]
        public decimal Total { get; set; }

        public virtual Fruit Fruit { get; set; }
        public int FruitId { get; set; }

        public virtual Sale Sale { get; set; }
        public int SaleId { get; set; }
    }
}
