using System.ComponentModel.DataAnnotations;
namespace Gestion_de_turnos.Models
{
    public class Servicio
    {
        [Key]
        public int Id { get; set; }
        public Servicio() { }
        //Servicios que cumple dicho lugar
        private string nombre;
        private int duracion;
        private decimal precio;

        public Servicio(string nombre , int Id ,int duracion,decimal precio) { 
                this.nombre = nombre;
                this.Id = Id;
                this.duracion = duracion;
                this.precio = precio;
        }

        public string getNombre() {  return nombre; }
        public void SetNombre(string nombre) { this.nombre = nombre; }
        public int getId() { return Id; }
        public void SetId(int id) {  this.Id = Id; }
        public decimal getPrecio() { return precio; }
        public void SetPrecio(decimal precio) {  this.precio = precio; }
        public  int getDuracion() { return duracion; }
        public void SetDuracion(int duracion) {  this.duracion = duracion;}

    }
}
