using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern_Estudo.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Por favor digite o Nome")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Por favor digite a Descrição")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Por favor digite o Preço")]
        public decimal Price { get; set; }
    }
}
