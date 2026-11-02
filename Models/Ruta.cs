namespace ClubSenderismo.Models;

public class Ruta
{
    public string Fecha { get; set; } = "";
    public string Nombre { get; set; } = "";
    public string Dificultad { get; set; } = "";
    public int Distancia { get; set; }
    public string Guia { get; set; } = "";
}