using System.ComponentModel.DataAnnotations;
namespace Gestion_de_turnos.Models
{
    public class Profesional
    {
        public Profesional() { }
        private string nombre, apellido, profesion;
        [Key]
        public int Legajo { get; set; }
        public Profesional(string nombre , string apellido ,string profesion,int Legajo) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.profesion = profesion;
            this.Legajo = Legajo;
        }
        public string getNombre() { return nombre; }
        public void setNombre( string nombre){ this.nombre = nombre; }
        public string getApellido() { return apellido; }
        public void setApellido(string apellido) { this.apellido = apellido; }
        public string getProfesion() { return profesion; }
        public void setProfesion(string profesion) { this.profesion = profesion; }
        public int getLegajo() { return Legajo; }
        public void setLegajo(int legajo) { this.Legajo = Legajo; }
    }

}
