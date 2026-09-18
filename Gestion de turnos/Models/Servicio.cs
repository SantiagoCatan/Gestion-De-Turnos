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
        public void SetNombre(string nombre) { this.nombre = nombre; }
        public int getId() { return id; }
        public void SetId(int id) {  this.id = id; }
        public decimal getPrecio() { return precio; }
        public void SetPrecio(decimal precio) {  this.precio = precio; }
        public  int getDuracion() { return duracion; }
        public void SetDuracion(int duracion) {  this.duracion = duracion;}

    }
}
