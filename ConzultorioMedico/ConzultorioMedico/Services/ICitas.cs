using ConzultorioMedico.Models;

namespace ConzultorioMedico.Services
{
    public interface ICitas
    {
        Task<List<Cita>> ObtenerCitasHoy();
        Task<List<Paciente>> Pacientes();

        Task<Cita> AgendarCita(Cita cita);
    }
}
