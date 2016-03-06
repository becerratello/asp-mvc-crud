using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosCargos.Core
{
    [Table("Empleados")]
    public class Empleado
    {
        public Empleado()
        {

        }

        public int EmpleadoID { get; set; }

        [Required(ErrorMessage = "Debe introducir un Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe introducir un Apellido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Debe introducir una Fecha")]
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime FechaNacimiento { get; set; }

        [Required()]
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }
    }
}
