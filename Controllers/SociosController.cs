using ClubSenderismo.Data;
using ClubSenderismo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClubSenderismo.Controllers;

public class SociosController : Controller
{
    // GET: /Socios  -> lista de socios inscritos
    public IActionResult Index()
    {
        return View(ClubData.Socios);
    }

    // GET: /Socios/Create  -> muestra el formulario vacío
    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Rutas = ClubData.Rutas;
        ViewBag.TotalSocios = ClubData.Socios.Count;
        return View(new Socio());
    }

    // POST: /Socios/Create  -> procesa el formulario
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Socio socio)
    {
        if (!socio.AceptoReglamento)
        ModelState.AddModelError(nameof(socio.AceptoReglamento), "Debes aceptar el reglamento del club");

        if (!ModelState.IsValid)
        {
            ViewBag.Rutas = ClubData.Rutas;
            ViewBag.TotalSocios = ClubData.Socios.Count;
            return View(socio);   // vuelve al formulario mostrando los errores
        }

        socio.Id = ClubData.NuevoId();
        ClubData.Socios.Add(socio);

        TempData["Mensaje"] = $"¡Listo {socio.Nombre}! Quedaste inscrito.";
        return RedirectToAction(nameof(Index));   // Post-Redirect-Get
    }

    // POST: /Socios/Delete/3
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int id)
    {
        ClubData.Socios.RemoveAll(s => s.Id == id);
        return RedirectToAction(nameof(Index));
    }
}