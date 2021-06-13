using Microsoft.EntityFrameworkCore;
using RepositoryPattern_Estudo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern_Estudo.Data
{
    public class RepositoryPatternDbContex : DbContext
    {

        public RepositoryPatternDbContex(DbContextOptions<RepositoryPatternDbContex> options)
           : base(options)
        {

        }


        //public RepositoryPatternDbContex(DbContextOptions<RepositoryPatternDbContex> options) : base(options)
        //{

        //}
        public DbSet<Product> Product { get; set; }
    }
}
