using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace checadorPrecios.Models
{
    public class checadorPreciosContext : DbContext
    {
        public checadorPreciosContext (DbContextOptions<checadorPreciosContext> options)
            : base(options)
        {
        }

        public DbSet<checadorPrecios.Models.Productos> Productos { get; set; }
    }
}
