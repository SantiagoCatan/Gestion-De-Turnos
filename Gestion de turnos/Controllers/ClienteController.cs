using Gestion_de_turnos.Models;
using Gestion_de_turnos.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_turnos.Controllers
{
    //Aca en Controllers es donde se resuelve los res y qes de los endpoint
    [ApiController]

    //una forma de volverse predeterminado las rutas 
    [Route("api/[controller]")]

    //se hace una herancia para poder utilizar los http
    public class ClienteController : ControllerBase
    {

        //Estoy inicializando(campo) con la clase ClienteService
        private readonly ClienteService _clienteServicie;

        //creo un constructor para utilizar a clienteService
        public ClienteController(ClienteService clienteService) {
            _clienteServicie = clienteService;

        }
        //Capturo el momento deseado con una clase de http
        [HttpGet("{id}")]

        //Este metodo se utliza para retorar un objeto o no
        public IActionResult ObtenerCliente(int id) {

            //lo se pasas por paramentro es el id  y se busca haciendo una invocacion a la logica de cliente servicio para encontrar dicho objeto
            Cliente? cliente = _clienteServicie.ObtenerClientePorId(id);
            //se evalua lo obtenido siedo null o no y retorarnandolo
            if (cliente == null) {
                return NotFound();
            }
            return Ok(cliente);
        }

        //Capturo el evento id y put me determina que es una actualizacion o modificacion
        [HttpPut("{id}")]

        //En este metodo le paso por parametro el cliente modificad y el id 
        public IActionResult ModificarCliente(int id, Cliente cliente) {
            Cliente? clienteActualizado = _clienteServicie.ModificarClienteId(id, cliente);
            //En el caso de que me retorne un null sera que no encuentra el cliente , y en el caso de que si se actualizara
            if (clienteActualizado == null) { return Ok(clienteActualizado); }
            return NotFound();
        }
        
        [HttpPost]

        public IActionResult CrearCliente(Cliente cliente) {
            // solo crear al cliente
            _clienteServicie.CrearCliente(cliente);

            return Ok(cliente);
        }
        [HttpDelete]

        public IActionResult DeleteCliente(int id) {

            // lo guardo en bool para que me retorne si se hizo o no
            bool eliminado =_clienteServicie.EliminarCliente(id);

            if (eliminado == true) { return Ok(); }
            return NotFound();
        }
        
    }
}
