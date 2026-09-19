using System.ComponentModel.DataAnnotations;
namespace Gestion_de_turnos.Models
{
    public class Servicio
    {
        [Key]
        public int Id { get; set; }
        public Servicio() { }
        //Servicios que cumple dicho lugar
        public string Nombre { get; set; } = string.Empty;
        public int Duracion { get; set; } = 0;
        public decimal Precio { get; set; } = 0;

        public Servicio(string Nombre , int Id ,int Duracion,decimal Precio) { 
                this.Nombre = Nombre;
                this.Id = Id;
                this.Duracion = Duracion;
                this.Precio = Precio;
        }
    }
}
