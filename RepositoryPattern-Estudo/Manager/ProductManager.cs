using EF.Core.Repository.Manager;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern_Estudo.Data;
using RepositoryPattern_Estudo.Interfaces.Manager;
using RepositoryPattern_Estudo.Models;
using RepositoryPattern_Estudo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern_Estudo.Manager
{
    public class ProductManager : CommonManager<Product>, IProductManager
    {
        public ProductManager(RepositoryPatternDbContex dbContext) : base(new ProductRepository(dbContext))
        {

        }

        public Product GetById(int id)
        {
            return GetFirstOrDefault(c => c.Id == id);
        }
    }
}
