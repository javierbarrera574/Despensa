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

    [Index(nameof(DNI), Name = "Proveedor: 34902124", IsUnique = true)]
    
    //Nombre del campo unico ClaveProducto

    public class Proveedores : EntityBase
    {

        [Required]

        public string Nombre { get; set; }

        [Required]

   
        [MaxLength(50)]

        public string CorreoElectronico { get; set; }

        [Required]

        [MaxLength(8, ErrorMessage = "El numero de telefono debe ser de {1} ocho caracteres")]
        public int NumeroTelefono { get; set; }


        [Column(TypeName = "Date")]

        public DateTime? FechaNacimiento { get; set; }


        [Required]
         
        [StringLength(8, ErrorMessage = "El DNI no debe superar los {1} nueve caracteres")]

        //La llave {1} toma el dato de limite de la coleccion
        public int DNI { get; set; }

        public HashSet<Categoria> categorias { get; set; }


    }

}


/*
 * 
 * UN PROVEEDOR DISTRIBUYE MUCHOS PRODUCTOS
 * 
 * 
 * INSTANCIA DE RELACION-->DISTRIBUIR
 * 
 * 
 *ES UNA TABLA INTERMEDIA QUE RELACIONA-->ES LA RELACION DE UNO A MUCHOS A UNO A MUCHOS-->CONVIRTIENDOSE EN MUCHOS A MUCHOS
 * 
 * 
 * UN PRODUCTO ES DISTRIBUIDO POR MUCHOS PROVEEDORES
 * 
 */