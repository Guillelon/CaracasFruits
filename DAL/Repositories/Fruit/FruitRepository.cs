using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class FruitRepository: IFruitRepository
    {
        private readonly CaracasFruitContext _context;

        public FruitRepository()
        {
            _context = new CaracasFruitContext();
        }

        public IList<Fruit> GetAll()
        {
            return _context.Fruits.ToList();
        }
    }
}
