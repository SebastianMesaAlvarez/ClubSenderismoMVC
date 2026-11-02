using System.ComponentModel.DataAnnotations;

namespace ClubSenderismo.Models;

public class Socio
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string Nombre { get; set; } = "";

    [Required(ErrorMessage = "El correo es obligatorio")]
    [EmailAddress(ErrorMessage = "Correo no válido")]
    public string Correo { get; set; } = "";

    public string? Telefono { get; set; }
    public DateTime? FechaNacimiento { get; set; }

    [Range(12, 99, ErrorMessage = "La edad debe estar entre 12 y 99 años")]
    public int? Edad { get; set; }

    [Required(ErrorMessage = "Selecciona tu nivel de experiencia")]
    public string? Nivel { get; set; }

    public List<string> Intereses { get; set; } = new();
    public string? Comentarios { get; set; }
    public string? Ruta { get; set; }
    public bool AceptoReglamento { get; set; }
}