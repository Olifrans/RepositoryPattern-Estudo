using Microsoft.AspNetCore.Mvc;
using RepositoryPattern_Estudo.Data;
using RepositoryPattern_Estudo.Interfaces.Manager;
using RepositoryPattern_Estudo.Interfaces.Repository;
using RepositoryPattern_Estudo.Manager;
using RepositoryPattern_Estudo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern_Estudo.Controllers
{
    public class ProductController : Controller
    {
        //Contexto do BD
        private RepositoryPatternDbContex _dbContext;
        private IProductManager _productManager;
        //private IProductRepository _productRepository;
        public ProductController(RepositoryPatternDbContex dbContext)
        {
            _dbContext = dbContext;
            _productManager = new ProductManager(_dbContext);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            string mgs = "";
            bool isSaved = _productManager.Add(product);
            if (isSaved)

            {
                mgs = "Produto salvo com sucesso";
            }
            else
            {
                mgs = "Atenção erro ao cadastrar o produto";
            }
            ViewBag.Mgs = mgs;
            return View();
        }

    }
}


//tut save data into database using 11:43