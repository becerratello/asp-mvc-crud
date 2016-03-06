using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosCargos.Core
{
    [Table("Cargos")]
    public class Cargo
    {
        public Cargo()
        {

        }
   

        public int CargoID { get; set; }

        [Required(ErrorMessage = "Debe introducir un Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe introducir un Importe")]
        public decimal Sueldo { get; set; }
    }
}