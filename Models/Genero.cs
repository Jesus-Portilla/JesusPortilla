using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JesusPortilla.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public Boolean estado { get; set; }

    }
}
