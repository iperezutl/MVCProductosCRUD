using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProductosCRUD.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Nombre { get; set; }
        [Display(Name = "Fecha de Alta")]
        [DataType(DataType.Date)]
        public DateTime FechaAlta { get; set; }
        [Range(0,100)]
        public int Existencia { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }
    }
}
