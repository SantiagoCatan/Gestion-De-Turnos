using Gestion_de_turnos.Models;
using Gestion_de_turnos.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_turnos.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class ServicieController : ControllerBase
    {
        private readonly ServicesService _services;
        public ServicieController(ServicesService services)
        {
            _services = services;
        }
        //CRUD 

        //GerId
        [HttpGet("{id}")]
        public IActionResult GetServicie(int id)
        {
            Servicio? servicio = _services.GetServicio(id);

            if (servicio == null) { return NotFound(); }
            return Ok(servicio);
        }

        //POST
        [HttpPost("{serivicio}")]
        public IActionResult PostServicie(Servicio servicio) {
            _services.AddServicio(servicio);

            return Ok(servicio);
        }

        //PUT
        [HttpPut("{id , servicio}")]
        public IActionResult PutServicie(int id, Servicio servicio) {
            Servicio? actualizadoServicio = _services.PutServicio(id, servicio);

            if (actualizadoServicio != null) { return NotFound(); }

            return Ok(actualizadoServicio);
        }

        //DELETE
        [HttpDelete("{id}")]
        public IActionResult DeleteServicio(int id)
        {
            bool eleminar = _services.DeleteId(id);
            if (eleminar != false) { return NotFound(false); }
            return Ok(true);
        }
    }
}
