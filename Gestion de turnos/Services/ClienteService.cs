using Gestion_de_turnos.Data;
using Gestion_de_turnos.Models;

namespace Gestion_de_turnos.Services
{
    public class ClienteService
    {
        private readonly SistemaTurnosContext _context;
           
            public ClienteService(SistemaTurnosContext context) {
            _context = context;
        }
        public List<Cliente>
            ObtenerClientes()
        {
            return _context.Clientes.ToList();
        }
    }
}
