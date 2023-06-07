using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JesusPortilla.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="varchar(10)")]
        public string NombreUsuario { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Clave { get; set;}
        [Required]
        public string estado { get; set; }
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }
        public List<HistorialAcceso> ListHistorialAcceso { get; set; }

    }
}
