using System.ComponentModel.DataAnnotations;
namespace Gestion_de_turnos.Models
{
    public class Cliente
    {

        //en la calse la tuve que actualizar de esta forma ya que el swagger me creasha porque debo pasarle las variables en estado publico , ya que el json no la reconoce
        //Ademas tenog que pasarle a los atributos con algun empty o 0 para inicializarlo
        public Cliente() { }
        //Constructor de clientes

        //Por el swagger tuve que pasarle un key primary prestablecido de forma escrita,y referenciando cual es el pk
        [Key]
        public int Id { get; set; } = 0;
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Sexo { get; set; } = string.Empty;
        public string Dni { get; set; } = string.Empty; 
        public int Edad { get; set; } = 0;


        public Cliente(string Nombre , string Apellido, string Sexo,string Dni, int Edad,int Id) {
                this.Nombre = Nombre;
                this.Apellido = Apellido;
                this.Sexo = Sexo;
                this.Dni = Dni;
                this.Edad = Edad;
                this.Id = Id;  
        }
    }   
}
