using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despensa.BD.Datos.Entidades
{
    [Index(nameof(NombreProducto),Name = "Producto: Dragon Ball Z", IsUnique =true)]//Nombre del campo unico ClaveProducto

    public class Productos:EntityBase
    {

        [Required]

        [MaxLength(12, ErrorMessage ="La clave debe ser una combinacion alfanumerica")]
        public string ClaveProducto { get; set; }

        [Required]
        public string NombreProducto { get; set; }

        public string DescripcionProducto { get; set; }

        public DateTime? FechaVencimientoProducto { get; set; }

        //deberia crear una llave foranea o compuesta que relacione la tabla esta con la de proveedores


        [Precision(14, 2)]
        public decimal PrecioProducto { get; set; }

        public bool VencimimentoProducto(DateTime FechaCaducidad, int id)
        {
            Productos productos = new Productos();

            bool CambiarProducto = false;

            if (FechaVencimientoProducto.Equals(FechaCaducidad))
            {
                Console.WriteLine("El producto esta vencido");

                if (productos.Id.Equals(id))
                {
                    CambiarProducto = true;
                }
            }
            return CambiarProducto;
        }

        public HashSet<Categoria> categorias { get; set; }

    }
}
