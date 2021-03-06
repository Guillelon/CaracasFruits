﻿using DAL.DTOs;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface ISaleRepository
    {
        bool Create(Sale sale);
        IList<FruitSale> GetSalesByDate(DateTime from, DateTime to);
    }
}
