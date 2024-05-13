using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalogo.Modelos
{
    public class Producto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del Producto es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? NombreProducto { get; set; }

        [Required(ErrorMessage = "Las existencias son requeridas")]
        [Range(0, int.MaxValue, ErrorMessage = "Las existencias deben ser un valor positivo")]
        public int Stock {  get; set; }

        [Required(ErrorMessage = "La descripción es requerida")]
        [StringLength(500, ErrorMessage = "Máximo 500 caracteres")]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "El precio es necesario")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser un valor positivo")]
        [Column(TypeName = "decimal(10,2)")] // Aquí especificamos el tipo de columna en SQL Server
        public decimal? Precio { get; set;}
       
    }
}
