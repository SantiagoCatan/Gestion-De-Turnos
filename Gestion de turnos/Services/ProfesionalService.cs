using Gestion_de_turnos.Data;
using Gestion_de_turnos.Models;
using Gestion_de_turnos.Services;

namespace Gestion_de_turnos.Services
{
    public class ProfesionalService
    {
        //tengo que saber el contexto del folder data
        private readonly SistemaTurnosContext _context;

        //constructor para utilizar el context
        public ProfesionalService(SistemaTurnosContext context) {
                _context = context;
        }

        //CRUD de Profesicional

        //Traeme toda la lista
        public List<Profesional> ListaProfesional() { 
            return _context.Profesional.ToList();
        }
        //Tramee uno solo por id
        public Profesional? GetProfesional(int legajo) {

            //busca el id en la lista
            List<Profesional>  lista =  ListaProfesional();

            Profesional? profesional= lista.Find(profesional => profesional.Legajo == legajo);

            if (profesional == null) { return null; }
            
            return profesional;

        }
        //Actualizame por id 
        public Profesional? ActualizarProfesional(int legajo , Profesional nuevoProfesional) {
            List<Profesional> lista = ListaProfesional();

            Profesional? profesional = lista.Find( profesional => profesional.Legajo == legajo);
            
            if (profesional == null) { return null; }

                profesional.Legajo = nuevoProfesional.Legajo;
                profesional.Nombre = nuevoProfesional.Nombre;
                profesional.Apellido = nuevoProfesional.Apellido;
                profesional.Profesion = nuevoProfesional.Profesion;
                    
                _context.SaveChanges();
                return profesional;
            }

        //Agrega un profesional 
        public void AgregarProfesional(Profesional profesional)
        {
            _context.Profesional.Add(profesional);
            _context.SaveChanges();
        }

        //Eliminame perfesional
        public bool EliminarProfesional(int legajo)
        {
            List<Profesional> lista = ListaProfesional();

            Profesional? profesional = lista.Find(profesional => profesional.Legajo == legajo);
            if (profesional == null) { return false; }
                   
            _context.Profesional.Remove(profesional);
            _context.SaveChanges();
             return true;
        }
    }
}
