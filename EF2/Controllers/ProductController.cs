using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF2.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF2.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List() => View(repository.Products);


        [HttpGet]
        public IActionResult Create() =>  View();
        [HttpPost]
        public IActionResult Create(Product product)
        {
            repository.CreateProduct(product);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Uptade(int id)
        {
          
            return View(repository.GetById(id));
        }
        [HttpPost]
        public IActionResult Uptade(Product product)
        {
            repository.UptadeProduct(product);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            repository.DeleteProduct(id);
            return RedirectToAction("List");
            
        }

        [HttpGet]
        public IActionResult Details(int id)
        {

            return View(repository.GetById(id));
        }

    }
}