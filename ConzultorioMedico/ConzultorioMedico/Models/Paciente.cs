using System.ComponentModel.DataAnnotations;

namespace ConzultorioMedico.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="el nombre del pacinte es requerido")]
        public string Name { get; set; }

        [Required(ErrorMessage = "el Primer appellido del pacinte es requerido")]
        public string Primer_Apellido { get; set; }
        public string? Segundo_Apellido { get; set; }

        [Required(ErrorMessage = "La {0} del pacinte es requerido")]
        [MinLength(18, ErrorMessage ="la {0} debe de tener {1} caracteres")]
        [MaxLength(18, ErrorMessage ="la {0} debe de tener {1} caracteres")]
        public string CURP { get; set; }
        [Required(ErrorMessage = "el Tipo de Sangre del pacinte es requerido")]
        public string TipoSangre { get; set; }
        public string? Ovserbaciones { get; set;}
    }
}
