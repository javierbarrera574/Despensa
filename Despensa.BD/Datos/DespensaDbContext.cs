using Despensa.BD.Datos.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despensa.BD.Datos
{
    public class DespensaDbContext : DbContext
    {

        

        public DespensaDbContext(DbContextOptions options) : base(options)
        {

        }



        public DespensaDbContext()
        {
            
        }


        public DbSet<Proveedores> Proveedores { get; set; }

        public DbSet<Productos> Producto_Proveedores { get; set; }



    }
}