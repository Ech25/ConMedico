using ConzultorioMedico.Models;

namespace ConzultorioMedico.Services
{
    public interface ICitas
    {
        Task<List<Cita>> ObtenerCitasHoy();
    }
}
