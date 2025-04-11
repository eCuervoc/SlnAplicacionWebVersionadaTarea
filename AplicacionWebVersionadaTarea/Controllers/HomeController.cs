using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AplicacionWebVersionadaTarea.Models;

namespace AplicacionWebVersionadaTarea.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    /// <summary>
    /// Prueba de versionado para clase - prueba numero uno (1)
    /// </summary>
    /// <returns>Retorno de prueba - numero uno (1)</returns>
    public IActionResult Index()
    {
        return View();   
    }
    /// <summary>
    /// Prueba de versionado para clase - prueba numero dos (2)
    /// </summary>
    /// <returns>Retorno de prueba - numero dos (2)</returns>
    public IActionResult Privacy()
    {
        return View();
    }


    /// <summary>
    /// Prueba de versionado para clase - prueba numero tres (3)
    /// </summary>
    /// <returns>Retorno de prueba - numero tres (3 )</returns>


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
