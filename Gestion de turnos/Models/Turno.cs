using System.ComponentModel.DataAnnotations;

namespace Gestion_de_turnos.Models
{
    public class Turno
    {
        public Turno() { }
        [Key]
        public int Id{ get; set;}
        
        private DateTime fecha;
        private string estados,lugar;
        private Cliente cliente;
        private Profesional profesional;

        private Servicio servicio;
        public Turno(int Id, DateTime fecha, string estados,string lugar, Cliente cliente, Profesional profesional,Servicio servicio) {
                this.Id = Id;
                this.fecha = fecha;
                this.estados = estados;
                this.lugar = lugar;
                this.cliente = cliente;
                this.profesional = profesional;
                this.servicio = servicio;
        }
    
        public int getId() { return Id; }
        public DateTime getFecha() { return fecha; }
        public string getEstados() { return estados; }
        public string getLugar() { return lugar; }
        public Cliente getCliente() { return cliente; }
        public Profesional GetProfesional() { return profesional; }
        public Servicio GetServicio() { return servicio; }
    }

}
