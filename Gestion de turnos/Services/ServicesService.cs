using Gestion_de_turnos.Data;
using Gestion_de_turnos.Models;

namespace Gestion_de_turnos.Services
{
    public class ServicesService
    {
        private readonly SistemaTurnosContext _context;
        
        public ServicesService(SistemaTurnosContext context)
        {
            _context = context;

        }

        //CRUD

        //GetAll

        public List<Servicio> GetListServicie()
        {
           return _context.Servicios.ToList();
        }
        //GetId
        public Servicio GetServicio(int id) {
                //traigo la lista de Servicios
            List<Servicio> lista = GetListServicie();
           //Recorro la lista y si encuentro que se guarde en servicio el objeto , y si no que sea null
            Servicio? servicio = lista.Find(servicio => servicio.Id == id);

            //en el caso de que me traiga null , si no lo es que me retorne el Servicio
            if (servicio == null) { return null; }
            return servicio;
        }
        //PutId
        public Servicio PutServicio(int id  , Servicio servicio) {
            List<Servicio> lista = _context.Servicios.ToList();
            Servicio? servicioActualizado = lista.Find(Servicio => servicio.Id == id);
            
            if (servicioActualizado != null) {

                servicio.Id = servicioActualizado.Id;
                servicio.Nombre = servicioActualizado.Nombre;
                servicio.Duracion = servicioActualizado.Duracion;
                servicio.Precio = servicioActualizado.Precio;
                _context.SaveChanges();

                return servicioActualizado;
            }

            return null;
            
        }
        //DeleteId

        public bool DeleteId(int id) {
            List<Servicio> lista = _context.Servicios.ToList();

            Servicio? servicio = lista.Find(Servicio => Servicio.Id == id);
            
            if(servicio != null) {
                _context.Servicios.Remove(servicio);
                _context.SaveChanges();
                return true; 
            }

            return false;
        }
        //Add
        public void AddServicio(Servicio servicio)
        {
            _context.Add(servicio);
            _context.SaveChanges();
        }
    }
}
