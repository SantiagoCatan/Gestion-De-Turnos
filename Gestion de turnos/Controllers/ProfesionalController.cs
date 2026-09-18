
using Microsoft.AspNetCore.Mvc;
using Gestion_de_turnos.Models;
using Gestion_de_turnos.Services;

namespace Gestion_de_turnos.Controllers
{
    //LLamo a la api y router
    [ApiController]
    [Route("api/[controller]")]

    //paso por herencia el controlador de EndPoint
    public class ProfesionalController : ControllerBase {

        private readonly ProfesionalService _ProfesionalService;

        public ProfesionalController(ProfesionalService profesionalService) {
            _ProfesionalService = profesionalService;
        }

        //CRUD  de servicios endpoint
        // get capturo el evento por el numero de legajo
        [HttpGet("{legajo}")]

        //Paramentro de legajo y devuelvo una res
        public IActionResult GetProfesional( int legajo) {
            Profesional? profesional = _ProfesionalService.GetProfesional(legajo);

            if (profesional == null) { return NotFound();}

            return Ok(profesional); }
        
        // put capturo el evento para modificar o actualizar
        [HttpPut("{legajo}")]
        //retorno un action 
        public IActionResult PutProfesional(int legajo , Profesional profesional) {
            Profesional? putProfesional = _ProfesionalService.ActualizarProfesional(legajo , profesional);

            if(putProfesional == null) { return NotFound(); }
            return Ok(putProfesional); 
        
        }
        
        //delete capturo el legajo 
        [HttpDelete("{legajo}")]
        //devuelvo una action resultado en el caso de q se pudo eliminar
        public IActionResult DeleteProfesional(int legajo) {
            //como la funcion EliminarProfesional de retorar un bool , dependeiendo de lo que me traiga puedo saber si se elimino o no
            bool eliminado = _ProfesionalService.EliminarProfesional(legajo);
        
            if (eliminado == false) { return NotFound(); }
            
            return Ok(true); 
        }
        
        // Post
        [HttpPost]
        public IActionResult PostProfesional(Profesional nuevoProfesional) {
           _ProfesionalService.AgregarProfesional(nuevoProfesional);
            return Ok(nuevoProfesional); 
        }

    }

}
