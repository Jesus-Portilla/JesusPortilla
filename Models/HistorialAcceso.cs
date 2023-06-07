using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JesusPortilla.Models
{
    public class HistorialAcceso
    {
        public int Id { get; set; } 
        public DateTime FechaHora { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set;}
    }
}
