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
            
                if (cliente.Id == id) { return cliente; }
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
            
            foreach (Cliente cliente in lista) { if (cliente.Id == id) {
                    
                    //hago la modificacion del cliente
                    cliente.Id = nuevosDatos.Id;
                    cliente.Nombre = nuevosDatos.Nombre;
                    cliente.Apellido = nuevosDatos.Apellido;
                    cliente.Dni = nuevosDatos.Dni;
                    cliente.Sexo = nuevosDatos. Sexo;
                    cliente.Edad = nuevosDatos.Edad;

                    _context.SaveChanges();  
                }
            }
            return null;    
        }
        public bool EliminarCliente(int id) {
            List<Cliente> lista = _context.Clientes.ToList();
            
            foreach (Cliente cliente in lista ) { if (cliente.Id == id) {
                    //si encuentra lo elimina y retorna true
                    _context.Clientes.Remove(cliente);
                    _context.SaveChanges();
                    return true;
                }}
            return false;
        }
    }
}
