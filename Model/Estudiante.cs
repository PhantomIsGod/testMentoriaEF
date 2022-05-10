using System.ComponentModel.DataAnnotations;

namespace testMentoriaEF.Model
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
    }
}
