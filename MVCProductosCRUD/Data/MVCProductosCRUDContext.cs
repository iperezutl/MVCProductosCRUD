using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCProductosCRUD.Models;

namespace MVCProductosCRUD.Data
{
    public class MVCProductosCRUDContext : DbContext
    {
        public MVCProductosCRUDContext (DbContextOptions<MVCProductosCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<MVCProductosCRUD.Models.Producto> Producto { get; set; } = default!;
    }
}
