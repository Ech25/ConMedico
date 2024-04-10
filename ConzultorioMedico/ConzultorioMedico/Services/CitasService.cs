using ConzultorioMedico.Data;
using ConzultorioMedico.Models;

namespace ConzultorioMedico.Services
{
    public class CitasService(ApplicationDbContext context) : ICitas
    {
        public Task<List<Cita>> ObtenerCitasHoy()
        {
            List<Cita> citas = new List<Cita>();
            context.Citas.toListAsync();
            return citas;
        }
    }
}
