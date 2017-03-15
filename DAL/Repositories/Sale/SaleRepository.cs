using DAL.DTOs;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SaleRepository: ISaleRepository
    {
        private readonly CaracasFruitContext _context;

        public SaleRepository()
        {
            _context = new CaracasFruitContext();
        }

        public bool Create(Sale sale)
        {
            _context.Sales.Add(sale);
            _context.SaveChanges();
            return true;
        }   
        
        public IList<FruitSale> GetSalesByDate(DateTime from, DateTime to)
        {
            var fromString = from.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            var toString = to.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            var fruitSale = _context.Database.SqlQuery<FruitSale>("SELECT FR.Name as FruitName, SUM(SI.UnitPrice*SI.Quantity) as TotalAmount, SUM(SI.Quantity) AS TotalQuantity" + 
                                                 " FROM SaleItems SI, Sales SA, Fruits FR"+
                                                 " WHERE SI.SaleId = SA.Id AND SI.FruitId = FR.Id AND SA.CreationDate >= '"+ fromString + "' "+
                                                 " AND SA.CreationDate <= '"+ toString + "' GROUP BY FR.Name").ToList();
            return fruitSale;
        }     
    }
}
