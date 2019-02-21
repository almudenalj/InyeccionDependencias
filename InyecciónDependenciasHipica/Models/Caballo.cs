using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InyecciónDependenciasHipica.Models
{
    [Table("Caballo")]
    public class Caballo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [Column("Nombre")]
        public String Nombre { get; set; }

        [Column("Id_Nivel")]
        public int IdNivel { get; set; }

        [Column("Id")]
        public int IdCaballo { get; set; }

        [Column("Ruta_Foto")]
        public String Foto { get; set; }
    }
}