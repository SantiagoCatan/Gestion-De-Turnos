namespace Gestion_de_turnos.Models
{
    public class Cliente
    {
        //Constructor de clientes
        private string nombre, apellido, sexo , dni;
        private int edad , id;


        public Cliente(string nombre , string apellido, string sexo,string dni, int edad,int id) {
                this.nombre = nombre;
                this.apellido = apellido;
                this.sexo = sexo;
                this.dni = dni;
                this.edad = edad;
                this.id = id;  
        }
        public string getNombre() { return nombre; }
        public void setNombre(string nombre) { this.nombre = nombre; }

        public string getApellido() { return apellido; }
        public void setApellido(string apellido) { this.apellido = apellido; }
        
        public string getSexo() { return sexo; }
        public void setSexo(string sexo) { this.sexo = sexo; }

        public string getDni() { return dni; }
        public void setDni(string dni) { this.dni = dni; }
        
        public int getEdad() { return edad; }
        public void setEdad(int edad) { this.edad = edad; }
        
        public int getId() { return id; }
        public void setId(int id) { this.id = id;}
    }   
}
