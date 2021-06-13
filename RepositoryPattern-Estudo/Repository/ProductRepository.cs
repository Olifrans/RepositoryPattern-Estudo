using Microsoft.EntityFrameworkCore;
using RepositoryPattern_Estudo.Interfaces.Manager;
using RepositoryPattern_Estudo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF.Core.Repository.Repository;
using RepositoryPattern_Estudo.Interfaces.Repository;

namespace RepositoryPattern_Estudo.Repository
{
    public class ProductRepository : CommonRepository<Product>, IProductRepository
    {
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {

        }

    }
}
