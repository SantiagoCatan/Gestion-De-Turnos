namespace Gestion_de_turnos.Models
{
    public class Servicio
    {
        //Servicios que cumple dicho lugar
        private string nombre;
        private int id, duracion;
        private decimal precio;

        public Servicio(string nombre , int id ,int duracion,decimal precio) { 
                this.nombre = nombre;
                this.id = id;
                this.duracion = duracion;
                this.precio = precio;
        }

        public string getNombre() {  return nombre; }
        public int getId() { return id; }
        public decimal getPrecio() { return precio; }
        public  int getDuracion() { return duracion; }

    }
}
