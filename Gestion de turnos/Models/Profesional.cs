using System.ComponentModel.DataAnnotations;
namespace Gestion_de_turnos.Models
{
    public class Profesional
    {
        [Key]
        public int Legajo { get; set; } = 0;
        
        public string Nombre { set; get; } = string.Empty;
        public string Apellido { set; get; } = string.Empty;
        public string Profesion { set; get; } = string.Empty;

        public Profesional() { }
        public Profesional(string Nombre , string Apellido ,string Profesion,int Legajo) {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Profesion = Profesion;
            this.Legajo = Legajo;
        }
    }

}
