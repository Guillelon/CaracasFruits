using DAL.Models;
using DAL.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaracasFruits.Controllers
{
    public class SalesController : Controller
    {
        private ISaleRepository _repository;

        public SalesController(ISaleRepository repository)
        {
            _repository = repository;
        }

        // GET: Sales
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public string _ProcessSale(string saleItems)
        {
            try
            {
                var salestemsModel = JsonConvert.DeserializeObject<List<SaleItem>>(saleItems);
                var sale = new Sale();
                sale.SaleItems = salestemsModel;
                _repository.Create(sale);
                return "The sale was processed with a total amount of $" + salestemsModel.Sum(s => s.Total) + ". You can review the sale at the report dashboard";
            }
            catch (JsonReaderException e)
            {
                return "The quantity must be a whole number";
            }
            catch(Exception e)
            {
                return "There has been a problem saving the data, please try again";
            }            
        }

        public ActionResult Report()
        {
           
            return View();
        }

        public ActionResult _Report(string from, string to)
        {
            var fromDate = DateTime.Parse(from);
            var toDate = DateTime.Parse(to);
            var dto = _repository.GetSalesByDate(fromDate, toDate);
            return PartialView("_ReportData", dto);
        }
    }
}