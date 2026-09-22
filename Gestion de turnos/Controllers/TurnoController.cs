using Gestion_de_turnos.Models;
using Gestion_de_turnos.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_turnos.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TurnoController : ControllerBase
    {
        private readonly TurnoService _turnoService;
        public TurnoController(TurnoService turnoService)
        {
            _turnoService = turnoService;

        }
        //CRUD

        [HttpGet("{id}")]

        public IActionResult GetTurno(int id)
        {
            Turno? turno = _turnoService.GetTurnoId(id);

            if (turno == null) { return NotFound(); }
            return Ok(turno);
        }
        [HttpPost("{turnoNuevo}")]

        public IActionResult AddTurno(Turno turnoNuevo) {

            _turnoService.AddTurno(turnoNuevo);

            return Ok(true);
        }
        [HttpPut("{id} , {cliente}")]

        public IActionResult PutTurno(int id , Turno turno)
        {
            Turno? turnoActualizado = _turnoService.PutTurno(id , turno);
            if (turnoActualizado == null) { return NotFound(false); }
            return Ok(true);
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteTurno(int id) {
            bool eliminado = _turnoService.DeleteTurno(id);
            if (eliminado == false) { return NotFound(false); }
            return Ok(true);
        }
    }
}
