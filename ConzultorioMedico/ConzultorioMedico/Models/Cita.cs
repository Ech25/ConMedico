using System.ComponentModel.DataAnnotations;

namespace ConzultorioMedico.Models
{
    public class Cita
    {
        public int Id { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Favor de elegir el paciente")]
        public int PacienteID { get; set; }
        public Paciente? Paciente { get; set; }
        public DateTime FechaHora { get; set; }
        public string? Ovserbacion { get; set; }

        ICollection<Paciente> Pacientes { get; set; }

    }
}
