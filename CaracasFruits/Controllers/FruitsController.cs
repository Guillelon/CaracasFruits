using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace CaracasFruits.Controllers
{
    public class FruitsController : Controller
    {
        private IFruitRepository _repository;

        public FruitsController(IFruitRepository repository)
        {
            _repository = repository;
        }
        public string _GetFruits()
        {
            var fruits = _repository.GetAll();
            var json = new JavaScriptSerializer().Serialize(fruits);
            return json;
        }
    }
}