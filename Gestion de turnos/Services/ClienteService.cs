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
        //trae todos los clientes 
        public List<Cliente> ObtenerClientes() {
                return _context.Clientes.ToList();
        }
        //Busca y trae el cliente especifico
        public Cliente? ObtenerClientePorId(int id) {

           List<Cliente> lista = ObtenerClientes();
            
            foreach (Cliente cliente in lista) {
            
                if (cliente.getId() == id) { return cliente; }
               }
            return null;
        }
        //Agrega el cliente 

        public void CrearCliente(Cliente cliente) { 
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }
        //modificia un cliente existente
        public Cliente? ModificarClienteId(int id,Cliente nuevosDatos) {
            List<Cliente> lista = _context.Clientes.ToList();
            
            foreach (Cliente cliente in lista) { if (cliente.getId() == id) {
                    
                    //hago la modificacion del cliente
                    cliente.setNombre(nuevosDatos.getNombre());
                    cliente.setApellido(nuevosDatos.getApellido());
                    cliente.setEdad(nuevosDatos.getEdad());
                    cliente.setDni(nuevosDatos.getDni());
                    cliente.setId(cliente.getId());
                    cliente.setSexo(nuevosDatos.getSexo());

                    _context.SaveChanges();  
                }
            }
            return null;    
        }
        public bool EliminarCliente(int id) {
            List<Cliente> lista = _context.Clientes.ToList();
            
            foreach (Cliente cliente in lista ) { if (cliente.getId() == id) {
                    //si encuentra lo elimina y retorna true
                    _context.Clientes.Remove(cliente);
                    _context.SaveChanges();
                    return true;
                }}
            return false;
        }
    }
}
