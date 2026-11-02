using ClubSenderismo.Models;

namespace ClubSenderismo.Data;

public static class ClubData
{
    public static List<Ruta> Rutas { get; } = new()
    {
        new Ruta { Fecha = "14 mar", Nombre = "Cascada del Encanto",    Dificultad = "Fácil",   Distancia = 8,  Guia = "Marta Londoño" },
        new Ruta { Fecha = "28 mar", Nombre = "Mirador de los Pinos",   Dificultad = "Media",   Distancia = 12, Guia = "Marta Londoño" },
        new Ruta { Fecha = "11 abr", Nombre = "Sendero del Río Azul",   Dificultad = "Difícil", Distancia = 15, Guia = "Carlos Méndez" },
        new Ruta { Fecha = "25 abr", Nombre = "Valle de las Mariposas", Dificultad = "Media",   Distancia = 10, Guia = "Carlos Méndez" }
    };

    public static List<Socio> Socios { get; } = new();
    private static int _siguienteId = 1;
    public static int NuevoId() => _siguienteId++;
}