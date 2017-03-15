using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }

        public IList<SaleItem> SaleItems { get; set; }

        public Sale()
        {
            CreationDate = DateTime.Now;
            SaleItems = new List<SaleItem>();
        }
    }
}
