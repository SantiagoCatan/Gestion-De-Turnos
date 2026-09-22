using System.ComponentModel.DataAnnotations;

namespace Gestion_de_turnos.Models
{
    public class Turno
    {
        [Key]
        public int Id{ get; set;}
        
        public DateTime Fecha { set; get; }
        public string Estados { set; get; } = "Pendiente";
        public string Lugar { set; get; } = string.Empty;
        public Cliente? Cliente { set; get; } = null;
        public Profesional? Profesional { set; get; } = null;
        public Servicio? Servicio { set; get; } = null;

        //Por el framework entity ,para utilizar los objetos tengoque traer y declarar las claves foreaneas de los objetos
        public int ClienteId { set; get; }
        public int ProfesionalLegajo {  set; get; }
        public int ServicioId { set; get; }
        
        public Turno() { }
        public Turno(int Id, DateTime Fecha, string Estados,string Lugar, Cliente Cliente, Profesional Profesional,Servicio Servicio) {
                this.Id = Id;
                this.Fecha = Fecha;
                this.Estados = Estados;
                this.Lugar = Lugar;
                this.Cliente = Cliente;
                this.Profesional = Profesional;
                this.Servicio = Servicio;
        }
    }

}
