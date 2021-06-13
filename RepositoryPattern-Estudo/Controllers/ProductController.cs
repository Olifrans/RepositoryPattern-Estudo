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
        /* //Contexto do BD
         private RepositoryPatternDbContex _dbContext;
         private IProductManager _productManager;
         public ProductController(RepositoryPatternDbContex dbContext)
         {
             _dbContext = dbContext;
             _productManager = new ProductManager(_dbContext);
         }
         */




        //Contexto do BD Dependency Injection in Asp Net Core MVC5
        private ProductManager _productManager;
        public ProductController(ProductManager productManager)
        {
            _productManager = productManager;
        }





        public IActionResult Index()
        {
            var products = _productManager.GetAll();
            return View(products);
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
                //mgs = "Produto salvo com sucesso";
                return RedirectToAction("Index");               
            }
            else
            {
                mgs = "Atenção erro ao cadastrar o produto";
            }
            ViewBag.Mgs = mgs;
            return View();
        }


        public IActionResult Edit(int id)
        {
            var product = _productManager.GetById(id);
            if (product==null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            string mgs = "";
            bool isUpdate = _productManager.Update(product);
            if (isUpdate)

            {
                mgs = "Produto atualizado com sucesso";
                return RedirectToAction("Index");
            }
            else
            {
                mgs = "Falha na atualização do produto";
            }
            ViewBag.Mgs = mgs;
            return View(product);
        }


        public IActionResult Details(int id)
        {
            var product = _productManager.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View();
        }


        public IActionResult Delete(int id)
        {
            var product = _productManager.GetById(id);
            if (product==null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            string mgs = "";
            bool isDeleted = _productManager.Delete(product);
            if (isDeleted)

            {
                mgs = "Produto removido com sucesso";
                return RedirectToAction("Index");
            }
            else
            {
                mgs = "Falha na remoção do produto";
            }
            ViewBag.Mgs = mgs;
            return View(product);
        }
    }
}
