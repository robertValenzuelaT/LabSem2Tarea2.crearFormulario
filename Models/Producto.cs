namespace LabSem2Tarea2.crearFormulario.Models
{
    public class Producto
    {
        public  string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; } 

        public decimal calcularSubTotal(){
            return Precio * Cantidad;
        }
        public decimal calcularTotal(){
            return (decimal)1.18 * calcularSubTotal();
        }
    }
}