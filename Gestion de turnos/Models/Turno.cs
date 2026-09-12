namespace Gestion_de_turnos.Models
{
    public class Turno
    {
        private int id;
        private DateTime fecha;
        private string estados,lugar;
        private Cliente cliente;
        private Profesional profesional;

        private Servicio servicio;
        public Turno(int id, DateTime fecha, string estados,string lugar, Cliente cliente, Profesional profesional,Servicio servicio) {
                this.id = id;
                this.fecha = fecha;
                this.estados = estados;
                this.lugar = lugar;
                this.cliente = cliente;
                this.profesional = profesional;
                this.servicio = servicio;
        }
    
        public int getId() { return id; }
        public DateTime getFecha() { return fecha; }
        public string getEstados() { return estados; }
        public string getLugar() { return lugar; }
        public Cliente getCliente() { return cliente; }
        public Profesional GetProfesional() { return profesional; }
        public Servicio GetServicio() { return servicio; }
    }

}
