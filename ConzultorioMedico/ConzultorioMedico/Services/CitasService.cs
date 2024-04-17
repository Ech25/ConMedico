using ConzultorioMedico.Data;
using ConzultorioMedico.Models;
using Microsoft.EntityFrameworkCore;

namespace ConzultorioMedico.Services
{
    public class CitasService(ApplicationDbContext context) : ICitas
    {
        
        public async Task<List<Cita>> ObtenerCitasHoy()
        {
            List<Cita> citas = new List<Cita>();
            citas = await context.Cita.Include(p => p.Paciente).OrderByDescending(f=>f.FechaHora).ToListAsync();
            return citas;
        }

        public async Task<List<Paciente>> Pacientes()
        {
            List<Paciente> pacientes = new List<Paciente>();
            pacientes= await context.Pacientes.ToListAsync();
            return pacientes;
        }

        
        public async Task<Cita> AgendarCita(Cita cita)
        {
            var respuesta = context.Cita.Add(cita);
            await context.SaveChangesAsync();
            return cita;
        }
    }
}
