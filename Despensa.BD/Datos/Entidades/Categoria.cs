using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despensa.BD.Datos.Entidades
{
    public class Categoria:EntityBase
    {

        public string ClasificacionCategoria { get; set; }

        public int ProveedorId { get; set; }

        public Proveedores proveedores { get; set; }

        public int ProductoId { get; set; }

        public Productos productos { get; set; }

        //TENGO DOS CLAVES FORANEAS PROVENIENTES DE LA RELACION UNO A MUCHOS DE PROVEEDORES

        //A LA ENTIDAD PRODUCTOS, CON LA CARDINALIDAD UNO A MUCHOS

        //CONVIRTIENDOSE EN UN TIPO DE RELACION MUCHOS A MUCHOS





    }
}


/*
 * 
 * TABLA INTERMEDIA QUE RELACIONA LA TABLA Productos Y Proveedores
 * 
 */