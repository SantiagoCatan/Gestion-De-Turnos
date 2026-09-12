namespace Gestion_de_turnos.Models
{
    public class Cliente
    {
        //Constructor de clientes
        private string nombre, apellido, sexo , dni;
        private int edad;


        public Cliente(string nombre , string apellido, string sexo,string dni, int edad) {
                this.nombre = nombre;
                this.apellido = apellido;
                this.sexo = sexo;
                this.dni = dni;
                this.edad = edad;
        }
        public string getNombre() { return nombre; }
        public string getApellido() { return apellido; }
        public string getSexo() { return sexo; }

        public string getDni() { return dni; }
        public int getEdad() { return edad; }

    }
}
