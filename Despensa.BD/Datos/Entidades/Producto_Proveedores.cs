using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despensa.BD.Datos.Entidades
{
    public class Producto_Proveedores
    {
        public int Id { get; set; }

        public string ClaveProducto { get; set; }

        public string NombreProducto { get; set; }

        public string DescripcionProducto { get; set; }

        public DateTime? FechaVencimientoProducto { get; set; }

        //deberia crear una llave foranea o compuesta que relacione la tabla esta con la de proveedores


        [Precision(14,2)]
        public decimal PrecioProducto { get; set; }

        public void VencimimentoProducto(DateTime FechaCaducidad)
        {

            if (FechaVencimientoProducto.Equals(FechaCaducidad))
            {

                Console.WriteLine("El producto esta vencido");

            }

        }
  


    }
}
