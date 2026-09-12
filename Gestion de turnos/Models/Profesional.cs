namespace Gestion_de_turnos.Models
{
    public class Profesional
    {
        private string nombre, apellido, profesion;
        private int legajo;


        public Profesional(string nombre , string apellido ,string profesion,int legajo) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.profesion = profesion;
            this.legajo = legajo;
        }
        public string getNombre() { return nombre; }
        public string getApellido() { return apellido; }
        public string getProfesion() { return profesion; }
        public int getLegajo() { return legajo; }
    }
}
