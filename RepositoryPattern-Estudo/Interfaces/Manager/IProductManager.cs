using RepositoryPattern_Estudo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF.Core.Repository.Interface.Manager;

namespace RepositoryPattern_Estudo.Interfaces.Manager
{
    public interface IProductManager : ICommonManager<Product>
    {
    }
}
