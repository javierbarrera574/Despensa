using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despensa.BD.Datos.Entidades
{
    public class Proveedores
    {

        [Key]

        //[identity]

        //[DatabaseGenerated]
        public int Id { get; set; }

        public string Nombre { get; set; }

        [Required]
       
        public string CorreoElectronico { get; set; }

        [Required]

        public int NumeroTelefono { get; set; }


        [Column(TypeName ="Date")]

        public DateTime? FechaNacimiento { get; set; }



    }
}
