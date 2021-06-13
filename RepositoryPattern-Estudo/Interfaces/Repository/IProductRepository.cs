using RepositoryPattern_Estudo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPattern_Estudo.Repository;
using EF.Core.Repository.Interface.Repository;

namespace RepositoryPattern_Estudo.Interfaces.Repository
{
    public interface IProductRepository : ICommonRepository<Product>
    {
    }
}
