using ClubSenderismo.Data;
using Microsoft.AspNetCore.Mvc;

namespace ClubSenderismo.Controllers;

public class RutasController : Controller
{
    // GET: /Rutas?dificultad=Media
    public IActionResult Index(string dificultad = "Todas")
    {
        var rutas = ClubData.Rutas.AsEnumerable();

        if (dificultad != "Todas")
            rutas = rutas.Where(r => r.Dificultad == dificultad);

        var lista = rutas.ToList();

        ViewBag.Dificultad = dificultad;
        ViewBag.TotalKm = lista.Sum(r => r.Distancia);

        return View(lista);
    }
}