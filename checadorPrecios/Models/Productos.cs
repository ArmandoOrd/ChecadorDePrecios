using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace checadorPrecios.Models
{
    public class Productos
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NombreProducto { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public string Categoria { get; set; }

      

    }
}
