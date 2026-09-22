using Gestion_de_turnos.Models;
using Gestion_de_turnos.Data;

namespace Gestion_de_turnos.Services
{
    public class TurnoService
    {
        private readonly SistemaTurnosContext _contexto;

        public TurnoService(SistemaTurnosContext contexto)
        {
            _contexto = contexto;

        }

        //Crud


        //GetAll
        public List<Turno> GetTurnoAll() {
            return _contexto.Turno.ToList();    
            
        }
        //GetId
        public Turno? GetTurnoId(int id)
        {
           List<Turno> lista= GetTurnoAll();

            Turno? turnoId = lista.Find(Turno => Turno.Id == id);

            if (turnoId == null) { return null; }
            
            return turnoId;
        }
        //DeleteId

        public bool DeleteTurno(int id) {
            List<Turno> lista = GetTurnoAll();

            Turno? turnoId = lista.Find(Turno => Turno.Id == id);

            if (turnoId == null) { return false; }
            
            _contexto.Turno.Remove(turnoId);
             return true;
            
        }
        //PutId

        public Turno? PutTurno(int id ,Turno turnoNuevo) {
            List<Turno> lista = GetTurnoAll();
            Turno? turno = lista.Find(Turno => turnoNuevo.Id == id);
            if (turno != null) {  
                //Lo que actualizo los atriburos de turnos y los clientes, profesionales,servicio le cambio solamente la referencia(id) 
                turno.Id = turnoNuevo.Id;
                turno.Lugar = turnoNuevo.Lugar;
                turno.Fecha = turnoNuevo.Fecha;
                turno.Estados = turnoNuevo.Estados;
                turno.ProfesionalLegajo = turnoNuevo.ProfesionalLegajo;
                turno.ClienteId = turnoNuevo.ClienteId;
                turno.ServicioId = turnoNuevo.ServicioId;
                _contexto.SaveChanges();
                
                return turno; 
            }
            return null;
        }
        //Add
        public void AddTurno(Turno turnoNuevo)
        {
            _contexto.Turno.Add(turnoNuevo);
            _contexto.SaveChanges();
        
        }
    }
}
