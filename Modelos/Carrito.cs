using System.ComponentModel.DataAnnotations;

namespace Catalogo.Modelos
{
    public class Carrito
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del Usuario es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? NombreUsuario { get; set; }

        [Required(ErrorMessage = "El nombre del Producto es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? NombreProducto { get; set; }

        [Required(ErrorMessage = "Las existencias son requeridas")]
        [Range(0, int.MaxValue, ErrorMessage = "Las existencias deben ser un valor positivo")]
        public int Cantidad { get; set; }


    }
}
