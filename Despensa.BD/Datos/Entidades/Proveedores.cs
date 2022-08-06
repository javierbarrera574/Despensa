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

    [Index(nameof(DNI), Name = "Proveedor: 34902124", IsUnique = true)]//Nombre del campo unico ClaveProducto


    //nameof--<>nombre de campo que va a ser clave unica

    //[Index(IsUnique = true)]
    public class Proveedores : EntityBase
    {

        ////[Key]

        ////[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //// public int Id { get; set; } Ya contiene el Id al heredear de EntityBase

        [Required]

        public string Nombre { get; set; }

        //[Required]

        //[Column(TypeName = "VARCHAR")]

        [StringLength(50)]

        public string CorreoElectronico { get; set; }

        [Required]

        [MaxLength(8, ErrorMessage = "El numero de telefono debe ser de {1} ocho caracteres")]
        public int NumeroTelefono { get; set; }


        [Column(TypeName = "Date")]

        public DateTime? FechaNacimiento { get; set; }//acepta valores nulo con el signo de pregunta


        [Required]

        [StringLength(8, ErrorMessage = "El DNI no debe superar los {1} nueve caracteres")]

        //La llave {1} toma el dato de limite de la coleccion
        public int DNI { get; set; }


    }

}
